﻿using AutoMapper;
using HootelBooking.Application.Contracts;
using HootelBooking.Application.Dtos.RoomType.Response;
using HootelBooking.Application.Models;
using MediatR;

namespace HootelBooking.Application.Features.RoomTypes.Query.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, Result<IEnumerable<RoomTypeResponseDto>>>
    {
          private readonly IRoomTypeRepository _roomTypeRepository; 
          private readonly IMapper _mapper;

        public GetAllQueryHandler(IRoomTypeRepository roomTypeRepository, IMapper mapper)
        {
            _roomTypeRepository = roomTypeRepository;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<RoomTypeResponseDto>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var res = await _roomTypeRepository.ListAllAsync();

            if (res.Any() )
            {
                var mappedResult = _mapper.Map<IEnumerable<RoomTypeResponseDto>>(res);
               

                return new Result<IEnumerable<RoomTypeResponseDto>>(mappedResult, 200, "Retrived Successfully");
            }
            return new Result<IEnumerable<RoomTypeResponseDto>>(404, "No RoomTypes Found");
        }
    }
}