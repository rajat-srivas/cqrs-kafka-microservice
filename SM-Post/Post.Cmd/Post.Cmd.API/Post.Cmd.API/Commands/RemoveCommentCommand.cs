using CQRS.Core.Commands;

namespace Post.Cmd.API.Commands
{
	public class RemoveCommentCommand: BaseCommand
	{
		public Guid CommendId { get; set; }

		public string UserName { get; set; }
	}
}
