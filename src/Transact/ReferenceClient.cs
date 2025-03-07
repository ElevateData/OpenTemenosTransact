﻿using OpenTemenos.Transacts.Reference;
using OpenTemenos.Transacts.Reference.AccountOfficers;
using OpenTemenos.Transacts.Reference.BalanceTypes;
using OpenTemenos.Transacts.Reference.Beneficiaries;
using OpenTemenos.Transacts.Reference.BICs;
using OpenTemenos.Transacts.Reference.Brokers;
using OpenTemenos.Transacts.Reference.BundleRates;
using OpenTemenos.Transacts.Reference.Categories;
using OpenTemenos.Transacts.Reference.ChequeTypes;
using OpenTemenos.Transacts.Reference.CollateralClassifications;
using OpenTemenos.Transacts.Reference.Companies;
using OpenTemenos.Transacts.Reference.Countries;
using OpenTemenos.Transacts.Reference.Currencies;
using OpenTemenos.Transacts.Reference.Dates;
using OpenTemenos.Transacts.Reference.Dealers;
using OpenTemenos.Transacts.Reference.IBANs;
using OpenTemenos.Transacts.Reference.InterestBases;
using OpenTemenos.Transacts.Reference.InterestRates;
using OpenTemenos.Transacts.Reference.Lookups;
using OpenTemenos.Transacts.Reference.NationalIds;
using OpenTemenos.Transacts.Reference.OrganizationStructures;
using OpenTemenos.Transacts.Reference.PeriodDates;
using OpenTemenos.Transacts.Reference.PortfolioAccounts;
using OpenTemenos.Transacts.Reference.Products;
using OpenTemenos.Transacts.Reference.RoundingRules;
using OpenTemenos.Transacts.Reference.TransactionCodes;
using OpenTemenos.Transacts.Reference.Treasuries;
using OpenTemenos.Transacts.Reference.UsBenOwnerTypes;
using OpenTemenos.Transacts.Reference.UsCounties;
using OpenTemenos.Transacts.Reference.UsCovenants;
using OpenTemenos.Transacts.Reference.UsCustomerRatings;
using OpenTemenos.Transacts.Reference.UsCustomerSuffixs;
using OpenTemenos.Transacts.Reference.UsCustomerTitles;
using OpenTemenos.Transacts.Reference.UsFdicClassCodes;
using OpenTemenos.Transacts.Reference.UsHoldTypes;
using OpenTemenos.Transacts.Reference.UsIdDocuments;
using OpenTemenos.Transacts.Reference.UsIndustries;
using OpenTemenos.Transacts.Reference.UsSectors;
using OpenTemenos.Transacts.Reference.UsSortCodes;
using OpenTemenos.Transacts.Reference.UsStates;

namespace OpenTemenos.Transacts;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;
    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAccountOfficerService AccountOfficerService => new AccountOfficerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBalanceTypeService BalanceTypeService => new BalanceTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBeneficiaryService BeneficiaryService => new BeneficiaryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBICService BICService => new BICService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBrokerService BrokerService => new BrokerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBundleRateService BundleRateService => new BundleRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICategoryService CategoryService => new CategoryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IChequeTypeService ChequeTypeService => new ChequeTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICollateralClassificationService CollateralClassificationService => new CollateralClassificationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICompanyService CompanyService => new CompanyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICountryService CountryService => new CountryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICurrencyService CurrencyService => new CurrencyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDateService DateService => new DateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDealerService DealerService => new DealerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IIBANService IBANService => new IBANService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInterestBaseService InterestBaseService => new InterestBaseService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInterestRateService InterestRateService => new InterestRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ILookupService LookupService => new LookupService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public INationalIdService NationalIdService => new NationalIdService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOrganizationStructureService OrganizationStructureService => new OrganizationStructureService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPeriodDateService PeriodDateService => new PeriodDateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPortfolioAccountService PortfolioAccountService => new PortfolioAccountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProductService ProductService => new ProductService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IRoundingRuleService RoundingRuleService => new RoundingRuleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITransactionCodeService TransactionCodeService => new TransactionCodeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITreasuryService TreasuryService => new TreasuryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsBenOwnerTypeService UsBenOwnerTypeService => new UsBenOwnerTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCountyService UsCountyService => new UsCountyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCovenantService UsCovenantService => new UsCovenantService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCustomerRatingService UsCustomerRatingService => new UsCustomerRatingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCustomerSuffixService UsCustomerSuffixService => new UsCustomerSuffixService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCustomerTitleService UsCustomerTitleService => new UsCustomerTitleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsFdicClassCodeService UsFdicClassCodeService => new UsFdicClassCodeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsHoldTypeService UsHoldTypeService => new UsHoldTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsIdDocumentService UsIdDocumentService => new UsIdDocumentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsIndustryService UsIndustryService => new UsIndustryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsSectorService UsSectorService => new UsSectorService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsSortCodeService UsSortCodeService => new UsSortCodeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsStateService UsStateService => new UsStateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
