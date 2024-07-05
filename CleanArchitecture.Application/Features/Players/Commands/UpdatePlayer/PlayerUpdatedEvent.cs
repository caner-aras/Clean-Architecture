using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.Players.Commands.UpdatePlayer
{
    public class PlayerUpdatedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerUpdatedEvent(Player player)
        {
            Player = player;
        }
    }
}
