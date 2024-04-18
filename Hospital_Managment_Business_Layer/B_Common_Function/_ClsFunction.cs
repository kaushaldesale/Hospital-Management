namespace Hospital_Managment_Business_Layer.Common_Functions
{
    public class _ClsFunction
    {
      

        public string Genrate_Code_For_User_View(string _docType, string _number)
        {
            //this is demo
            string _return = string.Empty;
            if (_number.ToString().Length == 1)
            {
                _number = "000" + _number;
            }
            else if (_number.ToString().Length == 2)
            {
                _number = "00" + _number;
            }
            else if (_number.ToString().Length == 3)
            {
                _number = "0" + _number;
            }
            return _return = _docType + "" + _number;

        }
    }
}
