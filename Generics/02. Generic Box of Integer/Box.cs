namespace _02.GenericBoxofInteger
{
	public class Box<T>
	{
		private T _item;

		public Box(T item)
		{
			_item = item;
		}

		public override string ToString()
		{
			return $"{_item.GetType().FullName}: {_item}";
		}
	}
}
