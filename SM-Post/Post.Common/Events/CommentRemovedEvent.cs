using CQRS.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Post.Common.Events
{
	internal class CommentRemovedEvent: BaseEvents
	{
		public CommentRemovedEvent() : base(nameof(CommentRemovedEvent))
		{

		}

		public Guid CommentId { get; set; }	
	}
}
