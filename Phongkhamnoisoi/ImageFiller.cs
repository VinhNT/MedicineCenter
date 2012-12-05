using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Phongkhamnoisoi
{
    class ImageFiller
    {
        Stack<Point> proccessingStack;
        public ImageFiller()
        {
            proccessingStack = new Stack<Point>();
            proccessingStack.Clear();
        }
        unsafe public Bitmap fillImageDirect(Bitmap src, Point startPosition, Color fillColor, byte tolerance)
        {
            return fillImageDirect(src, startPosition, fillColor, tolerance, tolerance, tolerance);
        }
        unsafe public Bitmap fillImageDirect(Bitmap src, Point startPosition, Color fillColor, byte tolRed, byte tolGreen, byte tolBlue)
        {
            int srcWidth = src.Width;
            int srcHeight = src.Height;
            byte colBytes = 4;
            BitmapData pixels = src.LockBits(new Rectangle(0, 0, srcWidth, srcHeight), ImageLockMode.ReadWrite,
                                            PixelFormat.Format32bppArgb);
            int stride = pixels.Stride;

            byte* pBits = (byte*)pixels.Scan0;
            int startX = startPosition.X;
            int startY = startPosition.Y;
            int curRed = stride * startY + startX * colBytes;
            byte sRed = pBits[curRed + 2];
            byte sGreen = pBits[curRed + 1];
            byte sBlue = pBits[curRed];

            if (checkPixel(pBits, curRed, fillColor.R, fillColor.G, fillColor.B, tolRed, tolGreen, tolBlue))
            {// The start color
                src.UnlockBits(pixels);
                return src;
            }
            Point lastL = new Point(-2, -2);
            Point lastU = new Point(-2, -2);
            Point currentPos;
            int x, y, strideY, y1;
            int count = 0;
            proccessingStack.Push(startPosition);
            while (proccessingStack.Count > 0)
            {
                currentPos = proccessingStack.Pop();
                //Scan to left
                x = currentPos.X;
                y = currentPos.Y;
                strideY = stride * y;
                while (x >= 0 && checkPixel(pBits, strideY + x * colBytes, sRed, sGreen, sBlue, tolRed, tolGreen, tolBlue)) x--;
                //Scan and fill right
                x++;
                lastL.X = -2; lastL.Y = -2;
                lastU.X = -2; lastU.Y = -2;

                while (x < srcWidth && checkPixel(pBits, strideY + x * colBytes, sRed, sGreen, sBlue, tolRed, tolGreen, tolBlue))
                {
                    //Check and push bellow
                    if (y + 1 < srcHeight)
                    {
                        if (checkPixel(pBits, strideY + stride + x * colBytes, sRed, sGreen, sBlue, tolRed, tolGreen, tolBlue))
                        {
                            if (!(lastL.X + 1 == x && lastL.Y == y + 1))
                            {
                                proccessingStack.Push(new Point(x, y + 1));
                                y1 = y + 1;
                            }
                            lastL.X = x; lastL.Y = y + 1;
                        }
                    }
                    //Check and push above
                    if (y - 1 >= 0)
                    {
                        if (checkPixel(pBits, strideY - stride + x * colBytes, sRed, sGreen, sBlue, tolRed, tolGreen, tolBlue))
                        {
                            if (!(lastU.X + 1 == x || lastU.Y == y - 1))
                            {
                                proccessingStack.Push(new Point(x, y - 1));
                            }
                            lastU.X = x; lastU.Y = y - 1;
                        }
                    }
                    curRed = strideY + x * colBytes;
                    //Fill the current pos
                    pBits[curRed + 2] = fillColor.R;
                    pBits[curRed + 1] = fillColor.G;
                    pBits[curRed] = fillColor.B;
                    x++;
                    count++;
                }

            }//While
            src.UnlockBits(pixels);
            return src;
        }
        unsafe public bool checkPixel(byte* src, int offset, byte sRed, byte sGreen, byte sBlue, byte tolRed, byte tolGreen, byte tolBlue)
        {
            //return src[offset] == sBlue && src[offset + 1] == sGreen && src[offset + 2] == sRed;
            try
            {
                return src[offset + 2] >= (sRed - tolRed) && src[offset + 2] <= (sRed + tolRed) &&
                        src[offset + 1] >= (sGreen - tolGreen) && src[offset + 1] <= (sGreen + tolGreen) &&
                        src[offset] >= (sBlue - tolBlue) && src[offset] <= (sBlue + tolBlue);
            }
            catch (Exception ) { return false; }
        }
    }
}
