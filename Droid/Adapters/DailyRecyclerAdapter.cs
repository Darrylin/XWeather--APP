using Android.Views;
using System.Collections.Generic;
using XWeather.Clients;
using XWeather.Domain;

namespace XWeather.Droid
{
    public class DailyRecyclerAdapter : BaseHeadRecyclerAdapter<ForecastDay, DailyViewHolder, WuLocation, DailyHeadHolder>
    {
        public override IList<ForecastDay> DataSet => WuClient.Shared.Selected?.Forecasts;

        public override WuLocation HeadData => WuClient.Shared.Selected;


        public DailyRecyclerAdapter(int cellResource, int headResource) : base(cellResource, headResource) { }


        protected override DailyViewHolder CreateCellViewHolder(View rootView) => DailyViewHolder.Create(rootView);

        protected override DailyHeadHolder CreateHeadViewHolder(View rootView) => DailyHeadHolder.Create(rootView);
    }
}