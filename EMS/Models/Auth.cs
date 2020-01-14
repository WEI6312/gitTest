using System;
using Dos.ORM;

namespace EMS.Models
{
    /// <summary>
    /// 实体类Auth。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("auth")]
    [Serializable]
    public partial class Auth : Entity
    {
        #region Model
        private int _Id;
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
            public readonly static Field All = new Field("*", "auth");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("id", "auth", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpiryTime = new Field("expiryTime", "auth", "");
        }
        #endregion
    }

}