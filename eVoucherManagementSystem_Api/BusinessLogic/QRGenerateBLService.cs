using eVoucherManagementSystem_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.BusinessLogic
{
    public class QRGenerateBLService
    {
        public QRGenerateBLService()
        {

        }

        public QRGenerateResponseModel QRGenerate(QRGenerateRequestModel reqModel)
        {
            QRGenerateResponseModel model = new QRGenerateResponseModel();
            var adfname = "eVoucher";
            var l_PromoCode = string.Empty;
         
            try
            {
                if (!string.IsNullOrEmpty(reqModel.PromoCode))
                {
                    l_PromoCode = reqModel.PromoCode;
                }
            
                var QrInfo = EMVQRGenerate(adfname, l_PromoCode);
                model.PromoCode = l_PromoCode;
                model.Base64ForQR = QrInfo;

            
                //var promoCode = RandomString(5,6);
                //model.Response = SubResponseModel.GetResponse(MessageResource.Success);
                model.RespCode = "000";
                model.RespDesp = "Success";
                goto Result;
            }
            catch (Exception ex)
            {
                throw;
            }
        Result:
            return model;
        }

        public static int RootAndAdfStringCount = 50;

        public static string EMVQRGenerate(string adfName, string l_PromoCode)
        {
            #region CPV01
            var paymentString = "85";
            var root = "CPV01";
            paymentString += StringToHex(root);
            #endregion

            #region ADF 61

            var ADFstring = "61";
            var ApplicationLabel = adfName;
            var hexADFName = "4F" + StringToHex(adfName);
            var hexApplicationLabel = "50" + StringToHex(ApplicationLabel);
            var TotalADFStringCount = (hexADFName.Length + hexApplicationLabel.Length) / 2;
            var hexTotalADFStringCount = String.Format("{0:X2}", TotalADFStringCount);

            paymentString += ADFstring + hexTotalADFStringCount + hexADFName + hexApplicationLabel;
            paymentString += ADFstring + hexTotalADFStringCount + hexADFName + hexApplicationLabel;
            RootAndAdfStringCount = paymentString.Length;

            #endregion

           
            var l_HexPhoneNo = "57" + StringToHex(l_PromoCode);
          

            #region Phone 

            var TotalHexString = string.Empty;
           

            var TotalAccInfoStringCount = (l_HexPhoneNo.Length + TotalHexString.Length) / 2;
            var hexTotalAccInfoStringCountt = String.Format("{0:X2}", TotalAccInfoStringCount);

            paymentString +=  hexTotalAccInfoStringCountt + l_HexPhoneNo  + TotalHexString;
            #endregion

            byte[] data = ConvertFromStringToHex(paymentString);
            string base64 = Convert.ToBase64String(data);

            return base64;
        }

        private static string StringToHex(string stringVal)
        {
            var output = string.Empty;
            var stringCount = stringVal.Length;
            output += String.Format("{0:X2}", stringCount);
            char[] values = stringVal.ToCharArray();
            foreach (char letter in values)
            {
                // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                // Convert the decimal value to a hexadecimal value in string form.
                string hexOutput = String.Format("{0:X}", value);
                //  Console.WriteLine("Hexadecimal value of {0} is {1}", letter, hexOutput);
                output += hexOutput;
            }
            return output;
        }

        public static byte[] ConvertFromStringToHex(string inputHex)
        {
            inputHex = inputHex.Replace(" ", "");

            byte[] resultantArray = new byte[inputHex.Length / 2];
            for (int i = 0; i < resultantArray.Length; i++)
            {
                resultantArray[i] = Convert.ToByte(inputHex.Substring(i * 2, 2), 16);
            }
            return resultantArray;
        }

       



    }
}
