using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;


namespace Phongkhamnoisoi
{
    class PrivateDataEncode
    {
        public const string key="vinhnt_gands@yahoo.com";
        private byte[] bKey;

        public PrivateDataEncode()
        {
            int i, n;
            char[] tmp = key.ToCharArray();
            n = key.Length;
            bKey = new byte[n];
            for (i = 0; i < n; i++)
            {
                bKey[i] = (byte)tmp[i];
            }
        }
        public byte[] encode1Level(byte[] source)
        {
            int i, j;
            byte[] tmp;
            int n, m;
            n  =  source.Length;
            tmp = new byte[n];
            m = bKey.Length;
            j = 0;
            for (i = 0; i < n; i++)
            {
                tmp[i] = (byte)(source[i] ^ bKey[j++]);
                if (j == m) j = 0;
            }
            return tmp;
        }
        public byte[] decode1Level(byte[] source)
        {
            return encode1Level(source);
        }
        public char[] encode1Level(char[] source)
        {
            int i, j;
            char[] tmp;
            int n, m;
            n = source.Length;
            tmp = new char[n];
            m = bKey.Length;
            j = 0;
            for (i = 0; i < n; i++)
            {
                tmp[i] = (char)(source[i] ^ bKey[j++]);
                if (j == m) j = 0;
            }
            return tmp;
        }
        public char[] decode1Level(char[] source)
        {
            return encode1Level(source);
        }
        public byte[] encodeFile(string sourceFile)
        {
            FileStream fs;
            long n;
            byte[] buffer;

            try { fs = new FileStream(sourceFile, FileMode.Open); }catch (Exception) { return null; }

            if (!fs.CanRead)
            {
                fs.Close();
                return null;
            }
            n = fs.Length;
            buffer = new byte[n];
            fs.Read(buffer, 0,(int) fs.Length);
            fs.Close();
            buffer = encode1Level(buffer);
            return buffer;
        }
        public byte[] decodeFile(string sourceFile)
        {
            return encodeFile(sourceFile);
        }
        public bool encodeFile(string sourceFile, string desFile)
        {
            byte[] buffer;
            FileStream fs;
            try
            {
                fs = new FileStream(desFile, FileMode.CreateNew);
            }
            catch (Exception) { return false; }
            buffer = encodeFile(sourceFile);
            if (buffer == null) { fs.Close(); return false; }
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
            return true;
        }
        public bool decodeFile(string sourceFile, string desFile)
        {
            return encodeFile(sourceFile, desFile);
        }
    }
    
	class PrivateDataPrepair
    {
		private const int BUFF_BLOCK = 8192;
		
    	public class PrivateDataCustomer
    	{
    		public System.Drawing.Image backGround;
    		public System.Drawing.Image reportHeader;    		
    		public System.IO.MemoryStream ReportDefinition;
    		public string ReportTitle;
    	}
    	
    	public PrivateDataPrepair()
    	{
    	
    	}
    	public static PrivateDataCustomer GetPrivateData(string fileName)
    	{
    		FileStream sourceData;
    		BinaryReader sr;    		
    		MemoryStream ms;
    		PrivateDataCustomer pdc;
    		
    		char[] signature;
    		byte[] buffer;    		
    		long len, sizeRead, i;
    		
    		pdc = new PrivateDataCustomer();    		
    		sourceData = new FileStream(fileName, FileMode.Open);
    		//Read signal
    		sr = new BinaryReader(sourceData);
    		len = sr.ReadInt32();
    		signature = new char[len+1];
    		sr.ReadByte();
    		sr.Read(signature, 0, (int)len);
    		len = sr.ReadInt32();
    		signature = new char[len];
    		sr.ReadByte();
    		sr.Read(signature, 0, (int)len);
    		//signature[len]=(char)0;
    		pdc.ReportTitle = new string(signature);    		
    		buffer = new byte[BUFF_BLOCK];
    		len = sr.ReadInt32();
    		
    		pdc.ReportDefinition = new System.IO.MemoryStream();    		
    		//Read report definition, this will be change to encoded version later
    		//May be encode entire file, instead of encoding piece by piece
    		i = 0;
    		do{    			   			
    			if (i+BUFF_BLOCK>len) 
    				sizeRead  = len-i;
    			else 
    				sizeRead = BUFF_BLOCK;
    			if (sizeRead>0)
    			{
    				sizeRead = sr.Read(buffer, 0, (Int32)sizeRead);
    				pdc.ReportDefinition.Write(buffer, 0, (Int32)sizeRead);    				
    				i+=sizeRead;
    			}
    		}while (i<len&&sizeRead>0);
    		//Read the header images
    		len = sr.ReadInt32();
    		ms = new MemoryStream();    		
    		//sr.ReadByte();
    		i = 0;
    		do{    			   			
    			if (i+BUFF_BLOCK>len) 
    				sizeRead  = len-i;
    			else 
    				sizeRead = BUFF_BLOCK;
    			if (sizeRead>0)
    			{
    				sizeRead = sr.Read(buffer, 0, (Int32)sizeRead);    				
    				ms.Write(buffer, 0, (int)sizeRead);
    				i+=sizeRead;
    			}
    		}while (i<len&&sizeRead>0);
    		pdc.reportHeader = Image.FromStream(ms);    		
    		ms.Dispose();    		
    		//Read the MainBackGround images
    		len = sr.ReadInt32();
    		ms = new MemoryStream();    		
    		//sr.ReadByte();
    		i = 0;
    		do{    			   			
    			if (i+BUFF_BLOCK>len) 
    				sizeRead  = len-i;
    			else 
    				sizeRead = BUFF_BLOCK;
    			if (sizeRead>0)
    			{
    				sizeRead = sr.Read(buffer, 0, (Int32)sizeRead);    				
    				ms.Write(buffer, 0, (int)sizeRead);
    				i+=sizeRead;
    			}
    		}while (i<len&&sizeRead>0);
    		pdc.backGround = Image.FromStream(ms);
    		sr.Close();
    		sourceData.Close();
    		return pdc;
    	}    	
    }
}
