using Common.Application;
using Domain.CommentAgg;

namespace Application.Comments.ChangeStatus
{
    public record ChangeCommentStatusCommand(long Id, CommentStatus Status) : IBaseCommand;
}