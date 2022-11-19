using System.IO;
using Message_service.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Message_service.Services
{
    /// <summary>
    /// Класс для удобной Json-сериализации списков типа "UserInfo" и "MessageInfo".
    /// </summary>
    public static class JsonSerializer
    {
        /// <summary>
        /// Метод сериализации списков.
        /// </summary>
        /// <param name="users">Список пользователей (типа "UserInfo").</param>
        /// <param name="messages">Список сообщений (типа "MessageInfo").</param>
        public static void DoSerialization(List<UserInfo> users, List<MessageInfo> messages)
        {
            if (users.Count != 0)
            {
                // Очищаем файл перед сериализацией.
                File.WriteAllText("users.json", string.Empty);
                File.WriteAllText("messages.json", string.Empty);
            }

            // Поскольку оба типа объекта List<T> никак не связаны, придется сериализовывать
            // данные в два этапа и в два файла - сначала список пользователей в файл "users.json",
            // а затем список сообщений в файл "messages.json".
            using (FileStream usersStream = new("users.json", FileMode.OpenOrCreate))
            {
                // Я не вижу смысла в сериализации пустых списков, поэтому выбрасываем исключение.
                if (users.Count == 0)
                    throw new System.ArgumentException("Пустой список невозможно сериализовать.");

                users.Sort((UserInfo first, UserInfo second) => first.Email.CompareTo(second.Email));
                DataContractJsonSerializer usersSerializer = new(typeof(List<UserInfo>));
                usersSerializer.WriteObject(usersStream, users);
            }

            using (FileStream messagesStream = new("messages.json", FileMode.OpenOrCreate))
            {
                // Проверка на пустоту списка сообщений бессмыслена, поскольку, если нет
                // пользователей, то нет и сообщений от них, а исключение, связанное с пустотой
                // списка пользователей выброшено уже ранее.
                DataContractJsonSerializer messagesSerializer = new(typeof(List<MessageInfo>));
                messagesSerializer.WriteObject(messagesStream, messages);
            }
        }

        /// <summary>
        /// Метод десериализации списков.
        /// </summary>
        /// <returns>users - список пользователей(типа "UserInfo"), messages - список сообщений (типа "MessageInfo").</returns>
        public static (List<UserInfo>, List<MessageInfo>) DoDeserialization()
        {
            List<UserInfo> users = new();
            List<MessageInfo> messages = new();

            // Ситуация аналогична - два разных несвязанных типа, которые необходимо десериализовать. Точно так
            // же используем два потока и два раза десериализуем json-файлы. При пустом списке выбрасывается исключение.
            using (FileStream usersStream = new("users.json", FileMode.Open))
            {
                usersStream.Position = 0;
                users = new DataContractJsonSerializer(typeof(List<UserInfo>)).ReadObject(usersStream) as List<UserInfo>;
                if (users.Count == 0)
                    throw new System.ArgumentException("Пустой список невозможно десериализовать.");
                users.Sort((UserInfo first, UserInfo second) => first.Email.CompareTo(second.Email));
            }

            using (FileStream messagesStream = new("messages.json", FileMode.Open))
            {
                messagesStream.Position = 0;
                // Проверки на длину списка нет, аналогично с "DoSerialization".
                messages = new DataContractJsonSerializer(typeof(List<MessageInfo>)).ReadObject(messagesStream) as List<MessageInfo>;
            }

            return (users, messages);
        }
    }
}
