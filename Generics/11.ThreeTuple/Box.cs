namespace _11.ThreeTuple
{
	public class Tuple<T, P, G>
	{
		private T _firstItem;
		private P _secondItem;
		private G _thirdItem;

		public Tuple(T firstItem, P secondItem, G thirdItem)
		{
			_firstItem = firstItem;
			_secondItem = secondItem;
			_thirdItem = thirdItem;
		}

		public override string ToString()
		{
			return $"{_firstItem} -> {_secondItem} -> {_thirdItem}";
		}
	}
}