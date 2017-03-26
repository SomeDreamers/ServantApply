﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServantApply.Common.Enums
{
    public enum PoliticsType
    {
        /// <summary>
        /// 党员
        /// </summary>
        PartyMember=1,
        /// <summary>
        /// 团员
        /// </summary>
        LeagueMember=2,
        /// <summary>
        /// 群众
        /// </summary>
        Citizen =3,
    }
    public static class PoliticsExtension
    {
        public static String getDescription(this PoliticsType type)
        {
            switch (type)
            {
                case PoliticsType.PartyMember:return "党员";
                case PoliticsType.LeagueMember:return "团员";
                case PoliticsType.Citizen:return "群众";
                default:return "";
            }
        }
        public static int getValue(this PoliticsType type)
        {
            return (int)type;
        }
    }

}