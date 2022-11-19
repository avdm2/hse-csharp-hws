using System.Runtime.Serialization;

namespace Message_service.Models
{
    /// <summary>
    /// Класс сообщений.
    /// </summary>
    [DataContract]
    public class MessageInfo
    {
        /// <summary>
        /// Тема письма.
        /// </summary>
        [DataMember]
        public string Subject { get; set; }
        /// <summary>
        /// Содержимое письма.
        /// </summary>
        [DataMember]
        public string Message { get; set; }
        /// <summary>
        /// Идентификатор отправителя.
        /// </summary>
        [DataMember]
        public string SenderId { get; set; }
        /// <summary>
        /// Идентификатор получателя.
        /// </summary>
        [DataMember]
        public string RecieverId { get; set; }
    }
}
