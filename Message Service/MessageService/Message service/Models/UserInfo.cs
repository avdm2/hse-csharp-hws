using System.Runtime.Serialization;

namespace Message_service.Models
{
    /// <summary>
    /// Класс пользователей.
    /// </summary>
    [DataContract]
    public class UserInfo
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [DataMember]
        public string UserName { get; set; }
        /// <summary>
        /// Электронный адрес пользователя (или его идентификатор).
        /// </summary>
        [DataMember]
        public string Email { get; set; }
    }
}
