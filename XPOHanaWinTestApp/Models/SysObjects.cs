using DevExpress.Xpo;
using System.Xml.Linq;
using System;

namespace XPOHanaWinTestApp.Models
{
    [Persistent("sys.objects")]
    internal class SysObjects : XPObject
    {
        [Persistent("OBJECT_OID")]
        public string OBJECT_OID { get; set; }
        public string SCHEMA_NAME { get; set; }
        public string OBJECT_NAME { get; set; }

        public override string ToString()
        {
            return $"{OBJECT_OID} - {OBJECT_NAME}";
        }
    }
}
