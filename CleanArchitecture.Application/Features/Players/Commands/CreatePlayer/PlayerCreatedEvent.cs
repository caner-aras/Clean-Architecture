using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.Players.Commands.CreatePlayer
{
    public class PlayerCreatedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerCreatedEvent(Player player)
        {
            Player = player;
        }
    }
}
