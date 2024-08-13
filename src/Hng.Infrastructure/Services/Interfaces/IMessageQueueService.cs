using Hng.Domain.Entities;
using Hng.Infrastructure.Utilities;

namespace Hng.Infrastructure.Services.Interfaces;

public interface IMessageQueueService
{
    public Task<Result<Message>> TryQueueEmailAsync(Message message);
    public Task<Message> TryQueueSMS(Message message);
    public Task<Result<Message>> SendInviteEmailAsync(string inviterName, string inviteeEmail, string organizationName, DateTimeOffset expiryDate, Guid inviteLink);

}
