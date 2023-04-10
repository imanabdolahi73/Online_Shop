namespace EndPoint.Site.Common
{
    public class clsEnums
    {
        public static string Get_VisibleStatus(int Visible)
        {
            if (Visible == 1)
            {
                return "قابل نمایش";
            }
            else
            {
                return "غیر قابل نمایش";
            }
        }
    }
}
