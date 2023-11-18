using System;
using System.IO;

namespace Color_Picker.Scripts.Data
{
    public class binaryReader
    {
        public static bool topMost;
        public static bool optimize;
        
        public static void SettingsRead()
        {
            if (File.Exists("Data.bin"))
            {
                try
                {
                    using (BinaryReader binaryReader = new BinaryReader(File.Open("Data.bin", FileMode.Open)))
                    {
                        topMost = binaryReader.ReadBoolean();
                        optimize = binaryReader.ReadBoolean();
                    }
                }
                catch (Exception ex){}
            }
        }
    }
}