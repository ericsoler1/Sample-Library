namespace Library.Contracts
{
    using System;

    public interface BookCheckedOutParent
    {
        Guid ParentId { get;  }
    }

    public interface BookCheckedOut : BookCheckedOutParent
    {
        Guid CheckOutId { get; }

        DateTime Timestamp { get; }

        Guid MemberId { get; }

        Guid BookId { get; }
    }
}