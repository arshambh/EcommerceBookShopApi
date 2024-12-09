using Common.Application;
using Common.Domain.ValueObjects;

namespace Application.Categories.Create
{
    public record CreateCategoryCommand(string Title, string Slug, SeoData SeoData) : IBaseCommand;
}