using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClubMembersList
{
    public enum MemberType{Full, OffPeak , Student, OAP}

    class Members
    {
        private int _memberCount;
        public static int TotalMembers;
        public int MemberCount
        {
            get { return _memberCount; }
            set
            {
                TotalMembers += value;
                _memberCount = value;
            }
        }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        //MemberType _membersType;
            
        public MemberType MembersType { get; set; }
        //{
        //    get
        //    {
        //        return _membersType;
        //    }
        //    set
        //    {
        //        if (MembersType != value)
        //        {
        //            _membersType = value;
        //            //RaisePropertyChanged("MembersType");
        //        }
        //    }
        //}
        //constructors
        public Members()
        {
            MemberCount++;
        }


        public Members(string name, DateTime joinDate,  MemberType membersType)
        {
            Name = name;
            MembersType = membersType;
            JoinDate = joinDate;
            MemberCount++;
        }

        //override ToString
        public override string ToString()
        {
            return $"{Name}, {MembersType}, {JoinDate.ToShortDateString()}";
        }

        //void RaisePropertyChanged(string prop)
        //{
        //    if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;
        //public static implicit operator Members(Members v)
        //{
        //   throw new NotImplementedException();
        //}
    }
}
