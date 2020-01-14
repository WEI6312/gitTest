using System;
using Dos.ORM;

namespace EMS.Models
{
    /// <summary>
    /// 实体类User。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("tb_user")]
    [Serializable]
    public partial class User : Entity
    {
        #region Model
        private int _Id;
        private string _Name;
        private string _Account;
        private string _Password;
        private int _User_level;
        private int _WorkcelID;
        private int _Phone;
        private string _E_mail;
        private string _Avatar;
        private DateTime _Entry_time;
        private int? _Age;
        private string _Token;
        private DateTime? _ExpiryTime;

        /// <summary>
        /// 
        /// </summary>
        [Field("id")]
        public int Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange("id");
                this._Id = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("name")]
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange("name");
                this._Name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("account")]
        public string Account
        {
            get { return _Account; }
            set
            {
                this.OnPropertyValueChange("account");
                this._Account = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("password")]
        public string Password
        {
            get { return _Password; }
            set
            {
                this.OnPropertyValueChange("password");
                this._Password = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("user_level")]
        public int User_level
        {
            get { return _User_level; }
            set
            {
                this.OnPropertyValueChange("user_level");
                this._User_level = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("workcelID")]
        public int WorkcelID
        {
            get { return _WorkcelID; }
            set
            {
                this.OnPropertyValueChange("workcelID");
                this._WorkcelID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("phone")]
        public int Phone
        {
            get { return _Phone; }
            set
            {
                this.OnPropertyValueChange("phone");
                this._Phone = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("e_mail")]
        public string E_mail
        {
            get { return _E_mail; }
            set
            {
                this.OnPropertyValueChange("e_mail");
                this._E_mail = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("avatar")]
        public string Avatar
        {
            get { return _Avatar; }
            set
            {
                this.OnPropertyValueChange("avatar");
                this._Avatar = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("entry_time")]
        public DateTime Entry_time
        {
            get { return _Entry_time; }
            set
            {
                this.OnPropertyValueChange("entry_time");
                this._Entry_time = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("age")]
        public int? Age
        {
            get { return _Age; }
            set
            {
                this.OnPropertyValueChange("age");
                this._Age = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("token")]
        public string Token
        {
            get { return _Token; }
            set
            {
                this.OnPropertyValueChange("token");
                this._Token = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("expiryTime")]
        public DateTime? ExpiryTime
        {
            get { return _ExpiryTime; }
            set
            {
                this.OnPropertyValueChange("expiryTime");
                this._ExpiryTime = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.Id,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.Id,
                _.Name,
                _.Account,
                _.Password,
                _.User_level,
                _.WorkcelID,
                _.Phone,
                _.E_mail,
                _.Avatar,
                _.Entry_time,
                _.Age,
                _.Token,
                _.ExpiryTime,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Id,
                this._Name,
                this._Account,
                this._Password,
                this._User_level,
                this._WorkcelID,
                this._Phone,
                this._E_mail,
                this._Avatar,
                this._Entry_time,
                this._Age,
                this._Token,
                this._ExpiryTime,
            };
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "tb_user");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("id", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("name", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Account = new Field("account", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Password = new Field("password", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field User_level = new Field("user_level", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WorkcelID = new Field("workcelID", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Phone = new Field("phone", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field E_mail = new Field("e_mail", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Avatar = new Field("avatar", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Entry_time = new Field("entry_time", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Age = new Field("age", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Token = new Field("token", "tb_user", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpiryTime = new Field("expiryTime", "tb_user", "");
        }
        #endregion
    }

}