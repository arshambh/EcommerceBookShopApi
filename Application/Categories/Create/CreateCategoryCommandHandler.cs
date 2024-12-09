using Common.Application;
using Domain.CategoryAgg;
using Domain.CategoryAgg.Services;

namespace Application.Categories.Create
{
    public class CreateCategoryCommandHandler : IBaseCommandHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _repository;
        private readonly ICategoryDomainService _domainServicer;

        public CreateCategoryCommandHandler(ICategoryRepository repository, ICategoryDomainService domainServicer)
        {
            _repository = repository;
            _domainServicer = domainServicer;
        }

        public async Task<OperationResult> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category(request.Title, request.Slug, request.SeoData, _domainServicer);
            await _repository.Add(category);
            await _repository.Save();
            return OperationResult.Success();
        }
    }
}