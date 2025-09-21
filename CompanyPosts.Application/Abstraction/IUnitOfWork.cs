﻿namespace CompanyPosts.Application.Abstraction;
public interface IUnitOfWork : IDisposable
{
	IGenericRepository<T> Repository<T>() where T : BaseEntity, IEntity;
	Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}