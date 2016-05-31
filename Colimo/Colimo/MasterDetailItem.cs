using System;

namespace Colimo
{
    internal class MasterDetailItem
    { 
       
        public Type TargetType { get;  set; }
        public string Title { get;  set; }

        public override string ToString()
        {
            return Title;
        }
    }
}