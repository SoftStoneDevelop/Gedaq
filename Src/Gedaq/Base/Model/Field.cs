using Microsoft.CodeAnalysis;

namespace Gedaq.Base.Model
{
    internal abstract class FieldInfo
    {
    }

    internal class Field
    {
        private bool _isAttributeChecked;

        public Field(bool isAttributeChecked = false)
        {
            _isAttributeChecked = isAttributeChecked;
        }

        public static Field OnlyPositionalField(int position)
        {
            return new Field
            {
                Position = position
            };
        }

        public bool IsAttributeChecked()
        {
            return _isAttributeChecked;
        }

        public void MarkAttributeChecked()
        {
            _isAttributeChecked = true;
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