﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.BookingSorucesRow>;
using MyRow = SmartERP.RoomSettings.BookingSorucesRow;

namespace SmartERP.RoomSettings
{
    public interface IBookingSorucesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BookingSorucesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBookingSorucesRetrieveHandler
    {
        public BookingSorucesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}