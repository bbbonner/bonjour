CREATE PROCEDURE [dbo].[ProductLoadAllPagegNopAjaxFilters]
@CategoryIds NVARCHAR (MAX), @ManufacturerId INT, @StoreId INT, @VendorId INT, @ParentGroupedProductId INT, @ProductTypeId INT, @VisibleIndividuallyOnly BIT, @ProductTagId INT, @FeaturedProducts BIT, @PriceMin DECIMAL (18, 4), @PriceMax DECIMAL (18, 4), @Keywords NVARCHAR (4000), @SearchDescriptions BIT, @SearchSku BIT, @SearchProductTags BIT, @UseFullTextSearch BIT, @FullTextMode INT, @FilteredSpecs NVARCHAR (MAX), @FilteredProductVariantAttributes NVARCHAR (MAX), @FilteredManufacturers NVARCHAR (MAX), @FilteredVendors NVARCHAR (MAX), @OnSale BIT, @LanguageId INT, @OrderBy INT, @AllowedCustomerRoleIds NVARCHAR (MAX), @PageIndex INT, @PageSize INT, @ShowHidden BIT, @LoadAvailableFilters BIT, @FilterableSpecificationAttributeOptionIds NVARCHAR (MAX) OUTPUT, @FilterableProductVariantAttributeIds NVARCHAR (MAX) OUTPUT, @FilterableManufacturerIds NVARCHAR (MAX) OUTPUT, @FilterableVendorIds NVARCHAR (MAX) OUTPUT, @HasProductsOnSale BIT OUTPUT, @TotalRecords INT OUTPUT
WITH ENCRYPTION
AS
BEGIN
--The script body was encrypted and cannot be reproduced here.
    RETURN
END


