using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Server.Circuits;
using HueControlBlazorExampleWebApp.Models;
using HueControlBlazorExampleWebApp.Providers;
using HueControlBlazorExampleWebApp.Services;

namespace HueControlBlazorExampleWebApp
{
    public class ClientCircuitHandler : CircuitHandler
    {
        private IConnectedClientService _clientService;
        private IUserStateProvider _usersProvider;
        private Services.IChatService _chatService;

        public ClientCircuitHandler(IConnectedClientService clientService, IChatService chatService, IUserStateProvider usersProvider)
        {
            _clientService = clientService;
            _chatService = chatService;
            _usersProvider = usersProvider;
        }

        public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            _clientService.Connect(circuit.Id);
            return base.OnCircuitOpenedAsync(circuit, cancellationToken);
        }

        public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            var user = _usersProvider.GetByClient(_clientService.Client);
            if (null != user)
                _chatService.Logout(user.Username);

            _clientService.Disconnect();

            return base.OnCircuitClosedAsync(circuit, cancellationToken);
        }
    }
}
