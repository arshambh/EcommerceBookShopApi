using Common.Domain.ValueObjects;

namespace Application.Categories.AddChild
{
    public record AddChildCategoryCommand(long ParentId, string Title, string Slug, SeoData SeoData) : Common.Application.IBaseCommand;
}