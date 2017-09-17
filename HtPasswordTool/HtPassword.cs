using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HtPasswordTool
{
    public class HtPassword
    {
        private string _name, _password;
        protected const int Md5DigitsLength = 16;
        protected const int SaltLength = 8;
        protected const string Chars = "abcdefghijklmnopqrstuvwxyz0123456789";

        public HtPassword()
        {
            _name = String.Empty;
            _password = String.Empty;
        }

        public HtPassword(string name, string password)
        {
            _name = name;
            _password = password;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string EncodePassword()
        {
            string salt = GenerateSalt();

            byte[] bsalt = Encoding.UTF8.GetBytes(salt);
            byte[] bpassword = Encoding.UTF8.GetBytes(_password);
            byte[] bapr1 = Encoding.UTF8.GetBytes("apr1");
            
            List<byte> text = new List<byte>();

            text.AddRange(Encoding.UTF8.GetBytes(_password + "$apr1$" + salt));

            byte[] md5 = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(_password + salt + _password));

            for (int i = _password.Length; i > 0; i -= Md5DigitsLength)
            {
                text.AddRange(SubByte(md5, 0, Math.Min(Md5DigitsLength, i)));
            }

            for (int i = _password.Length; i > 0; i >>= 1)
            {
                text.Add((i & 1) > 0 ? (byte)0 : bpassword[0]);
            }

            md5 = MD5.Create().ComputeHash(text.ToArray());

            for (int i = 0; i < 1000; i++)
            {
                List<byte> newText = new List<byte>();

                newText.AddRange((i & 1) > 0 ? bpassword : md5);

                if ((i%3) != 0)
                {
                    newText.AddRange(bsalt);
                }

                if ((i%7) != 0)
                {
                    newText.AddRange(bpassword);
                }

                newText.AddRange((i & 1) > 0 ? md5 : bpassword);
                md5 = MD5.Create().ComputeHash(newText.ToArray());
            }
            

            text = new List<byte>();

            for (int i = 0; i < 5; i++) {
                int k = i + 6;
                int j = i + 12;

                if (j == 16){
                    j = 5;
                }

                text.Insert(0, md5[j]);
                text.Insert(0, md5[k]);
                text.Insert(0, md5[i]);
            }

            text.Insert(0, md5[11]);
            text.Insert(0, 0);
            text.Insert(0, 0);

            List<byte> b64 = new List<byte>();

            b64.AddRange(Encoding.UTF8.GetBytes(Convert.ToBase64String(text.ToArray(), 0, text.Count)));
            b64.RemoveAt(0);
            b64.RemoveAt(0);

            b64.Reverse();

            text = EncodeBytes(b64);
            text.Insert(0,36);

            int index = 0;
            foreach (byte s in bsalt)
            {
                text.Insert(index++,s);
            }

            text.Insert(0,36);

            index = 0;
            foreach (byte s in bapr1)
            {
                text.Insert(index++,s);
            }

            text.Insert(0,36);

            return Encoding.Default.GetString(text.ToArray());
        }

        protected string GenerateSalt()
        {
            string retval = "";
            Random rand = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < 8; i++)
            {
                retval += Chars[rand.Next(Chars.Length)];
            }

            return retval;
        }

        public override string ToString()
        {
            return _name + ":" + EncodePassword();
        }

        protected static byte[] SubByte(byte[] bytes, int from, int count)
        {
            byte[] retval = new byte[count];

            if (from + count > bytes.Length)
            {
                return null;
            }

            int index = 0;

            for (int i = from; i < from + count; i++)
            {
                retval[index++] = bytes[i];
            }

            return retval;
        }

        protected static List<byte> EncodeBytes(List<byte> list)
        {
            List<byte> ret = new List<byte>();
            foreach (byte b in list)
            {
                switch (b)
                {
                    case 65:
                        ret.Add(46);
                        break;
                    case 66:
                        ret.Add(47);
                        break;
                    case 67:
                        ret.Add(48);
                        break;
                    case 68:
                        ret.Add(49);
                        break;
                    case 69:
                        ret.Add(50);
                        break;
                    case 70:
                        ret.Add(51);
                        break;
                    case 71:
                        ret.Add(52);
                        break;
                    case 72:
                        ret.Add(53);
                        break;
                    case 73:
                        ret.Add(54);
                        break;
                    case 74:
                        ret.Add(55);
                        break;
                    case 75:
                        ret.Add(56);
                        break;
                    case 76:
                        ret.Add(57);
                        break;
                    case 77:
                        ret.Add(65);
                        break;
                    case 78:
                        ret.Add(66);
                        break;
                    case 79:
                        ret.Add(67);
                        break;
                    case 80:
                        ret.Add(68);
                        break;
                    case 81:
                        ret.Add(69);
                        break;
                    case 82:
                        ret.Add(70);
                        break;
                    case 83:
                        ret.Add(71);
                        break;
                    case 84:
                        ret.Add(72);
                        break;
                    case 85:
                        ret.Add(73);
                        break;
                    case 86:
                        ret.Add(74);
                        break;
                    case 87:
                        ret.Add(75);
                        break;
                    case 88:
                        ret.Add(76);
                        break;
                    case 89:
                        ret.Add(77);
                        break;
                    case 90:
                        ret.Add(78);
                        break;
                    case 97:
                        ret.Add(79);
                        break;
                    case 98:
                        ret.Add(80);
                        break;
                    case 99:
                        ret.Add(81);
                        break;
                    case 100:
                        ret.Add(82);
                        break;
                    case 101:
                        ret.Add(83);
                        break;
                    case 102:
                        ret.Add(84);
                        break;
                    case 103:
                        ret.Add(85);
                        break;
                    case 104:
                        ret.Add(86);
                        break;
                    case 105:
                        ret.Add(87);
                        break;
                    case 106:
                        ret.Add(88);
                        break;
                    case 107:
                        ret.Add(89);
                        break;
                    case 108:
                        ret.Add(90);
                        break;
                    case 109:
                        ret.Add(97);
                        break;
                    case 110:
                        ret.Add(98);
                        break;
                    case 111:
                        ret.Add(99);
                        break;
                    case 112:
                        ret.Add(100);
                        break;
                    case 113:
                        ret.Add(101);
                        break;
                    case 114:
                        ret.Add(102);
                        break;
                    case 115:
                        ret.Add(103);
                        break;
                    case 116:
                        ret.Add(104);
                        break;
                    case 117:
                        ret.Add(105);
                        break;
                    case 118:
                        ret.Add(106);
                        break;
                    case 119:
                        ret.Add(107);
                        break;
                    case 120:
                        ret.Add(108);
                        break;
                    case 121:
                        ret.Add(109);
                        break;
                    case 122:
                        ret.Add(110);
                        break;
                    case 48:
                        ret.Add(111);
                        break;
                    case 49:
                        ret.Add(112);
                        break;
                    case 50:
                        ret.Add(113);
                        break;
                    case 51:
                        ret.Add(114);
                        break;
                    case 52:
                        ret.Add(115);
                        break;
                    case 53:
                        ret.Add(116);
                        break;
                    case 54:
                        ret.Add(117);
                        break;
                    case 55:
                        ret.Add(118);
                        break;
                    case 56:
                        ret.Add(119);
                        break;
                    case 57:
                        ret.Add(120);
                        break;
                    case 43:
                        ret.Add(121);
                        break;
                    case 47:
                        ret.Add(122);
                        break;
                }
            }

            return ret;
        }
    }
}
