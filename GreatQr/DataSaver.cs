using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace GreatQr
{
    public class DataSaver
    {
        public string key;
        public DataSaver()
        {
        }
        public void setKey(string dataKey)
        {
            key = dataKey;
        }
        public string getKey()
        {
            return key;
        }
        public async Task<bool> setStringValue(string value)
        {
            try
            {
                await SecureStorage.SetAsync(key, value);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public async Task<string> getStringValue()
        {
            try
            {
                return await SecureStorage.GetAsync(key);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool removeValue()
        {
            try
            {
                SecureStorage.Remove(key);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
