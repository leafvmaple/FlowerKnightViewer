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
            MaxCharacterBox = user.maxCharacterBox;
            MaxCharacterEquipmentBox = user.maxCharacterEquipmentBox;
            MaxFriend = user.maxFriend;
            GameMoney = user.gameMoney;
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


        private long _Level;
        public long Level
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

        private long _ExperienceForNexeLevel;
        public long ExperienceForNexeLevel
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

        private long _MaxCharacterBox;

        public long MaxCharacterBox
        {
            get { return _MaxCharacterBox; }
            set
            {
                if (_MaxCharacterBox != value)
                {
                    _MaxCharacterBox = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private long _MaxCharacterEquipmentBox;

        public long MaxCharacterEquipmentBox
        {
            get { return _MaxCharacterEquipmentBox; }
            set
            {
                if (_MaxCharacterEquipmentBox != value)
                {
                    _MaxCharacterEquipmentBox = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private long _MaxFriend;
        public long MaxFriend
        {
            get { return _MaxFriend; }
            set
            {
                if (_MaxFriend != value)
                {
                    _MaxFriend = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private long _GameMoney;
        public long GameMoney
        {
            get { return _GameMoney; }
            set
            {
                if (_GameMoney != value)
                {
                    _GameMoney = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private long _ChargeMoney;
        public long ChargeMoney
        {
            get { return _ChargeMoney; }
            set
            {
                if (_ChargeMoney != value)
                {
                    _ChargeMoney = value;
                    this.RaisePropertyChanged();
                }
            }
        }
    }
}
