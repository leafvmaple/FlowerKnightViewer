using FlowerWrapper.Models.Raw;
using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerWrapper.Models
{
    public class Knight : NotificationObject
    {
        public Knight(fkapi_data data)
        {
            NickName = data.nickname;
        }

        public void UpdateKnight(fkapi_user user)
        {
            Level = user.levelId;
            ExperienceForNexeLevel = user.levelExperience;
        }

        public void UpdateNickName(fkapi_data data)
        {
            NickName = data.nickname;
        }

        private string _NickName;
        public string NickName
        {
            get { return _NickName; }
            set
            {
                if (_NickName != value)
                {
                    _NickName = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private int _Rank;
        public int Rank
        {
            get { return _Rank; }
            set { _Rank = value; }
        }

        private string _Comment;

        public string Comment
        {
            get { return _Comment; }
            set { _Comment = value; }
        }


        private int _Level;
        public int Level
        {
            get { return _Level; }
            set
            {
                if (_Level != value)
                {
                    _Level = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private int _ExperienceForNexeLevel;
        public int ExperienceForNexeLevel
        {
            get { return _ExperienceForNexeLevel; }
            set
            {
                if (_ExperienceForNexeLevel != value)
                {
                    _ExperienceForNexeLevel = value;
                    this.RaisePropertyChanged();
                }
            }
        }
    }
}
