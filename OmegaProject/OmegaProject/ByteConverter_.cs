using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OmegaProject
{
    public class ByteConverter_ : INotifyPropertyChanged
    {
        // multiple call functions for use in every line of code and function who got called here
        public event PropertyChangedEventHandler PropertyChanged;
        private int _4byte;
        private int _4byteX8;
        private int _4bytex8p6;
        private int _hex;
        private int _u30;
        private float _ieeex32;
        private double _ieeex64;
        // OnPropertyChanged call function 
        private void OnPropertyChanged(string PropertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        // U30 string calculation
        public string U30
        {
            get => _u30.ToString("X");
            set
            {
                _u30 = HandleHexInput(value);
                _4byte = ConvertU30ToInt(_u30);
                _4byteX8 = _4byte * 8;
                _4bytex8p6 = _4byte * 8 + 6;
                _hex = _4byte;
                _ieeex32 = Convert.ToSingle(_4byte);
                _ieeex64 = Convert.ToDouble(_4byte);
                OnPropertyChanged("U30");
            }
        }
        // Hex string calculation
        public string Hex
        {
            get => _hex.ToString("X");
            set
            {
                _hex = HandleHexInput(value);
                _4byte = _hex;
                _4byteX8 = _4byte * 8;
                _4bytex8p6 = _4byte * 8 + 6;
                _u30 = ConvertIntToU30();
                _ieeex32 = Convert.ToSingle(_4byte);
                _ieeex64 = Convert.ToDouble(_4byte);
                OnPropertyChanged("Hex");
            }
        }
        // FourByte_x8_p6 int calculation
        public int FourByte_x8_p6
        {
            get => _4bytex8p6;
            set
            {
                _4bytex8p6 = value;
                _4byte = (int)((double)(_4bytex8p6 - 6) / 8.0);
                _4byteX8 = _4byte * 8;
                _hex = _4byte;
                _u30 = ConvertIntToU30();
                _ieeex32 = Convert.ToSingle(_4byte);
                _ieeex64 = Convert.ToDouble(_4byte);
                OnPropertyChanged("4bytex8p6");
            }
        }
        // FourByte_x8 int calculation
        public int FourByte_x8
        {
            get => _4byteX8;
            set
            {
                _4byteX8 = value;
                _4byte = (int)((double)_4byteX8 / 8.0);
                _4bytex8p6 = _4byte * 8 + 6;
                _hex = _4byte;
                _u30 = ConvertIntToU30();
                _ieeex32 = Convert.ToSingle(_4byte);
                _ieeex64 = Convert.ToDouble(_4byte);
                OnPropertyChanged("4byteX8");
            }
        }
        // FourByte int calculation
        public int FourByte
        {
            get => _4byte;
            set
            {
                _4byte = value;
                _4byteX8 = _4byte * 8;
                _4bytex8p6 = _4byte * 8 + 6;
                _hex = _4byte;
                _u30 = ConvertIntToU30();
                _ieeex32 = Convert.ToSingle(_4byte);
                _ieeex64 = Convert.ToDouble(_4byte);
                OnPropertyChanged("4byte");
            }
        }
        // Ieeex32 string calculation
        public string Ieeex32
        {
            get
            {
                byte[] bytes = BitConverter.GetBytes(_ieeex32);
                return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}",
                    new object[]
                {
                    bytes[3],
                    bytes[2],
                    bytes[1],
                    bytes[0]
                });
            }
            set
            {
                try
                {
                    _ieeex32 = HandleIEEE754x32Input(value);
                    _4byte = Convert.ToInt32(_ieeex32);
                    _ieeex64 = Convert.ToDouble(_4byte);
                    _hex = _4byte;
                    _4byteX8 = _4byte * 8;
                    _4bytex8p6 = _4byte * 8 + 6;
                    _u30 = ConvertIntToU30();
                    OnPropertyChanged("ieeex32");
                }
                catch { }
            }
        }
        // Ieeex64 string calculation
        public string Ieeex64
        {
            get
            {
                byte[] bytes = BitConverter.GetBytes(_ieeex64);
                return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}",
                    new object[]
                {
                    bytes[7],
                    bytes[6],
                    bytes[5],
                    bytes[4],
                    bytes[3],
                    bytes[2],
                    bytes[1],
                    bytes[0]
                });
            }
            set
            {
                _ieeex64 = HandleIEEEx64Input(value);
                try
                {
                    _4byte = Convert.ToInt32(_ieeex32);
                    _ieeex64 = Convert.ToDouble(_4byte);
                    _hex = _4byte;
                    _4byteX8 = _4byte * 8;
                    _4bytex8p6 = _4byte * 8 + 6;
                    _u30 = ConvertIntToU30();
                    OnPropertyChanged("ieeex32");
                }
                catch { }
            }
        }
        // UnityFloatx32 string calculation
        public string UnityFloatx32
        {
            get { return BitConverter.ToString(BitConverter.GetBytes(_ieeex32)).Replace("-", " "); }
            set
            {
                try
                {
                    _ieeex32 = HandleIEEE754x32Input(value);
                    _4byte = Convert.ToInt32(_ieeex32);
                    _hex = _4byte;
                    _4byteX8 = _4byte * 8;
                    _4bytex8p6 = _4byte * 8 + 6;
                    _u30 = ConvertIntToU30();
                    OnPropertyChanged("ieeex32");
                }
                catch { }
            }
        }
        // HandleIEEE754x32Input float calculation
        private float HandleIEEE754x32Input(string val)
        {
            val = val.Replace(" ", string.Empty);
            if (Regex.IsMatch(val, "^[\\da-fA-F]+$"))
            {
                try { return BitConverter.ToSingle(BitConverter.GetBytes(Convert.ToInt32(val, 16)), 0); }
                catch { return 0f; }
            }
            return 0f;
        }
        // HandleIEEEx64Input double calculation
        private double HandleIEEEx64Input(string val)
        {
            val = val.Replace(" ", string.Empty);
            if (Regex.IsMatch(val, "^[\\da-fA-F]+$"))
            {
                try { return BitConverter.ToDouble(BitConverter.GetBytes(Convert.ToInt64(val, 16)), 0); }
                catch { }
            }
            return 0.0;
        }
        // HandleHexInput int calculation
        private int HandleHexInput(string val)
        {
            if (Regex.IsMatch(val, "^[\\da-fA-F]+$"))
            {
                try { return Convert.ToInt32(val, 16); }
                catch { }
            }
            return 0;
        }
        // ConvertU30ToInt int calculation
        private int ConvertU30ToInt(int val)
        {
            int result;
            try
            {
                string text = Convert.ToString(val, 2);
                string text2 = string.Empty;
                while (text.Length > 0)
                {
                    if (text.Length > 8)
                    {
                        text2 = text.Substring(1, 7) + text2;
                        text = text.Substring(8);
                    }
                    else
                    {
                        while (text.Length < 8)
                            text = "0" + text;

                        text2 = text + text2;
                        text = "";
                    }
                }
                result = Convert.ToInt32(text2, 2);
            }
            catch (Exception) { result = _u30; }
            return result;
        }
        // ConvertIntToU30 int calculation
        private int ConvertIntToU30()
        {
            if (_4byte < 1)
                return 0;

            string text = Convert.ToString(_4byte, 2);
            string text2 = "";
            while (text.Length > 0)
            {
                if (text.Length > 7)
                {
                    text2 = text2 + "1" + text.Substring(text.Length - 7);
                    text = text.Substring(0, text.Length - 7);
                }
                else
                {
                    while (text.Length < 8)
                        text = "0" + text;

                    text2 += text;
                    text = "";
                }
            }
            try { return Convert.ToInt32(text2, 2); }
            catch { }
            return _u30;
        }
    }
}
