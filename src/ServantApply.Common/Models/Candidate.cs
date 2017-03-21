﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServantApply.Common.Models
{
    /// <summary>
    /// 考生信息
    /// </summary>
    public class Candidate
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string TrueName { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Tell { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 学校
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string Card { get; set; }

        /// <summary>
        /// 名族
        /// </summary>
        public string Nation { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public int Politics { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        public int Education { get; set; }
    }
}
