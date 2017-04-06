using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dashboard.WFA
{
    public class ConversionDX
    {
        public static DevExpress.Data.UnboundColumnType TypeToColumnType(Type t)
        {
            if (t == typeof(int) || t == typeof(int?))
                return DevExpress.Data.UnboundColumnType.Integer;
            else if (t == typeof(string))
                return DevExpress.Data.UnboundColumnType.String;
            else if (t == typeof(bool) || t == typeof(bool?))
                return DevExpress.Data.UnboundColumnType.Boolean;
            else if (t == typeof(double) || t == typeof(double?))
                return DevExpress.Data.UnboundColumnType.Decimal;
            else if (t == typeof(DateTime) || t == typeof(DateTime?))
                return DevExpress.Data.UnboundColumnType.DateTime;
            else
                return DevExpress.Data.UnboundColumnType.Bound;
        }

        public static DevExpress.XtraEditors.Mask.MaskType StringToMaskType(string s)
        {
            DevExpress.XtraEditors.Mask.MaskType masktype = DevExpress.XtraEditors.Mask.MaskType.None;
            switch (s.ToUpper())
            {
                case "NUMERIC":
                    masktype = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    break;
                case "NUM":
                    masktype = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    break;
                case "DATETIME":
                    masktype = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                    break;
                case "REGEX":
                    masktype = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    break;
                case "REGULAR":
                    masktype = DevExpress.XtraEditors.Mask.MaskType.Regular;
                    break;
                case "SIMPLE":
                    masktype = DevExpress.XtraEditors.Mask.MaskType.Simple;
                    break;
                case "SIMP":
                    masktype = DevExpress.XtraEditors.Mask.MaskType.Simple;
                    break;
                case "CUSTOM":
                    masktype = DevExpress.XtraEditors.Mask.MaskType.Custom;
                    break;
            }
            return masktype;
        }
    }
}
