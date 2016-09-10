using System;

namespace ShoppingCart.Models
{
    [Serializable]
    public class ItemKey : IEquatable<ItemKey>
    {
        public int Quantity { get; internal set; }
        public string ProductName { get; internal set; }
        public int ItemId { get; internal set; }
        public string UnitQty { get; internal set; }
        public string ImageFilePath { get; internal set; }

        public override bool Equals(object obj)
        {
            var myItem = obj as ItemKey;
            return !ReferenceEquals(myItem, null) && (ItemId== myItem.ItemId); 
        }
        public override int GetHashCode()
        {
            var id = ItemId;
            return id.GetHashCode();
        }
        public bool Equals(ItemKey myItem)
        {
            return string.Equals(ItemId, myItem.ItemId);
        }
    }
}