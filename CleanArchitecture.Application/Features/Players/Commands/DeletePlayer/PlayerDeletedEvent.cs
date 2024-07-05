using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.Players.Commands.DeletePlayer
{
    public class PlayerDeletedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerDeletedEvent(Player player)
        {
            Player = player;
        }
    }
}
