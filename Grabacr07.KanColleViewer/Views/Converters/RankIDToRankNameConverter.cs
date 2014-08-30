﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Grabacr07.KanColleViewer.Properties;


namespace Grabacr07.KanColleViewer.Views.Converters
{
	public class RankIDToRankNameConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is int)
			{
				var ID = (int)value;
				switch (ID)
				{
					case 1:
						return Resources.Rank_Marshal_Admiral;
					case 2:
						return Resources.Rank_Admiral;
					case 3:
						return Resources.Rank_Vice_Admiral;
					case 4:
						return Resources.Rank_Rear_Admiral;
					case 5:
						return Resources.Rank_Captain;
					case 6:
						return Resources.Rank_Commander;
					case 7:
						return Resources.Rank_Novice_Commander;
					case 8:
						return Resources.Rank_Lieutenant_Commander;
					case 9:
						return Resources.Rank_Lieutenant;
					case 10:
					default:
						return Resources.Rank_Novice_Lieutenant;
				}

			}
			return "N/A";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
