﻿namespace Domain.ProductAgg.Services
{
    public interface IProductDomainService
    {
        bool SlugIsExist(string slug);
    }
}