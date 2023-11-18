using System.IO;

namespace Color_Picker.Scripts.Data
{
    public class binaryWriter
    {
        public static void SettingsWrite(bool topMostValue,bool optimizeValue)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open("Data.bin", FileMode.OpenOrCreate)))
            {
                binaryWriter.Write(topMostValue);
                binaryWriter.Write(optimizeValue);
            }
        }
    }
}