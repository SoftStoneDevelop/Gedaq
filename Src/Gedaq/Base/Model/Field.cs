namespace Gedaq.Base.Model
{
    internal abstract class FieldInfo
    {
    }

    internal class Field
    {
        public static Field OnlyPositionalField(int position)
        {
            return new Field
            {
                Position = position
            };
        }

        /// <summary>
        /// Name of property in type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of property in sql (and in reader)
        /// </summary>
        public string SQLName { get; set; }

        /// <summary>
        /// Position in SQL row
        /// </summary>
        public int? Position { get; set; }

        public FieldInfo AdditionalInfo { get; set; }

        public bool HaveAdditionalInfo => AdditionalInfo != null;
    }
}