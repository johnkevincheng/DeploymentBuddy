using System;
using System.Xml.Serialization;

namespace DeploymentBuddy
{
    /// <summary>
    /// Provides functions to serialize and deserialize to xml.
    /// </summary>
    public static class Serializers
    {
        /// <summary>
        /// Serialize the object into an xml string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The Serializable object to serialize.</param>
        /// <returns></returns>
        public static String SerializeXml<T>(this T obj)
        {
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stringwriter, obj);

            return stringwriter.ToString();
        }

        /// <summary>
        /// Deserialize an xml string into the target object type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml">The xml string.</param>
        /// <returns></returns>
        public static T DeserializeXml<T>(this String xml)
        {
            var stringReader = new System.IO.StringReader(xml);
            var serializer = new XmlSerializer(typeof(T));

            return (T)serializer.Deserialize(stringReader);
        }
    }
}
