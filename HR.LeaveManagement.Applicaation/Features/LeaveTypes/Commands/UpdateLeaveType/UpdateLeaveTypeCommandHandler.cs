﻿using AutoMapper;
using HR.LeaveManagement.Applicaation.Contracts.Persistence;
using HR.LeaveManagement.Application.Contracts.Logging;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Applicaation.Features.LeaveTypes.Commands.UpdateLeaveType
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IAppLogger<UpdateLeaveTypeCommandHandler> _logger;

        public UpdateLeaveTypeCommandHandler(IMapper mapper,ILeaveTypeRepository leaveTypeRepository, IAppLogger<UpdateLeaveTypeCommandHandler> logger)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
            _logger=logger;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveTypetoUpdate = _mapper.Map<Domain.LeaveType>(request);

            if (leaveTypetoUpdate == null)
            {
                _logger.LogWarning("Validation errors in update request for {0} - {1}",nameof(LeaveTypes),request.Id);
                throw new NotFoundException(nameof(LeaveTypes), request.Name);
            }
            await _leaveTypeRepository.UpdateAsync(leaveTypetoUpdate);
            return Unit.Value;
        }
    }
}
