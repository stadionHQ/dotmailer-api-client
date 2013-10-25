using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using dotMailer.Api.Resources.Enums;
using dotMailer.Api.Resources.Models;

namespace dotMailer.Api
{
    /// <summary>
    /// Generated by the dotMailer API WADL Parser
    /// </summary>
    public partial class Client
    {
		/// <summary>
		/// Deletes a contact from a given address book.
		/// </summary>
		public ServiceResult DeleteAddressBookContact(int addressBookId, int contactId)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts/{contactId}", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId },
				{ "contactId", contactId }
			});
			return Delete(request);
		}

		/// <summary>
		/// Deletes all contacts from a given address book.
		/// </summary>
		public ServiceResult DeleteAddressBookContacts(int addressBookId)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId }
			});
			return Delete(request);
		}

		/// <summary>
		/// Deletes multiple contacts from an address book
		/// </summary>
		public ServiceResult DeleteAddressBookContactsInbulk(int addressBookId, Int32List contactIds)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts/inbulk", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId },
			});
			return Delete(request);
		}

		/// <summary>
		/// Removes an attachment from a campaign.
		/// </summary>
		public ServiceResult DeleteCampaignAttachment(int campaignId, int documentId)
		{
			var request = new Request("v2/campaigns/{campaignId}/attachments/{documentId}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "documentId", documentId }
			});
			return Delete(request);
		}

		/// <summary>
		/// Deletes all transactional data for a contact.
		/// </summary>
		public ServiceResult DeleteContactTransactionalData(string collectionName, string email)
		{
			var request = new Request("v2/contacts/{email}/transactional-data/{collectionName}", 
			new Dictionary<string, object>
			{
				{ "collectionName", collectionName },
				{ "email", email }
			});
			return Delete(request);
		}

		/// <summary>
		/// Deletes all transactional data for a contact.
		/// </summary>
		public ServiceResult DeleteContactTransactionalData(string collectionName, int id)
		{
			var request = new Request("v2/contacts/{id}/transactional-data/{collectionName}", 
			new Dictionary<string, object>
			{
				{ "collectionName", collectionName },
				{ "id", id }
			});
			return Delete(request);
		}

		/// <summary>
		/// Deletes a data field within the account.
		/// </summary>
		public ServiceResult<ApiDependencyResult> DeleteDataField(string name)
		{
			var request = new Request("v2/data-fields/{name}", 
			new Dictionary<string, object>
			{
				{ "name", name }
			});
			return Delete<ApiDependencyResult>(request);
		}

		/// <summary>
		/// Gets a summary of information about the current status of the account.
		/// </summary>
		public ServiceResult<ApiAccount> GetAccountInfo()
		{
			var request = new Request("v2/account-info");
			return Get<ApiAccount>(request);
		}

		/// <summary>
		/// Gets an address book by id.
		/// </summary>
		public ServiceResult<ApiAddressBook> GetAddressBookById(int id)
		{
			var request = new Request("v2/address-books/{id}", 
			new Dictionary<string, object>
			{
				{ "id", id }
			});
			return Get<ApiAddressBook>(request);
		}

		/// <summary>
		/// Gets any campaigns that have been sent to an address book.
		/// </summary>
		public ServiceResult<ApiCampaignList> GetAddressBookCampaigns(int addressBookId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/address-books/{addressBookId}/campaigns?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignList>(request);
		}

		/// <summary>
		/// Gets a list of contacts in a given address book.
		/// </summary>
		public ServiceResult<ApiContactList> GetAddressBookContacts(int addressBookId, bool? withFullData = null, int? select = null, int? skip = null)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts?withFullData={withFullData}&select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId },
				{ "withFullData", withFullData },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactList>(request);
		}

		/// <summary>
		/// Gets a list of contacts who were modified since a given date, in a given address book.
		/// </summary>
		public ServiceResult<ApiContactList> GetAddressBookContactsModifiedSinceDate(int addressBookId, DateTime date, bool? withFullData = null, int? select = null, int? skip = null)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts/modified-since/{date}?withFullData={withFullData}&select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId },
				{ "withFullData", withFullData },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactList>(request);
		}

		/// <summary>
		/// Gets a list of contacts who have unsubscribed from a given address book.
		/// </summary>
		public ServiceResult<ApiContactSuppressionList> GetAddressBookContactsUnsubscribedSinceDate(int addressBookId, DateTime date, int? select = null, int? skip = null)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts/unsubscribed-since/{date}?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactSuppressionList>(request);
		}

		/// <summary>
		/// Gets all address books
		/// </summary>
		public ServiceResult<ApiAddressBookList> GetAddressBooks(int? select = null, int? skip = null)
		{
			var request = new Request("v2/address-books?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiAddressBookList>(request);
		}

		/// <summary>
		/// Gets all private address books
		/// </summary>
		public ServiceResult<ApiAddressBookList> GetAddressBooksPrivate(int? select = null, int? skip = null)
		{
			var request = new Request("v2/address-books/private?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiAddressBookList>(request);
		}

		/// <summary>
		/// Gets all public address books
		/// </summary>
		public ServiceResult<ApiAddressBookList> GetAddressBooksPublic(int? select = null, int? skip = null)
		{
			var request = new Request("v2/address-books/public?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiAddressBookList>(request);
		}

		/// <summary>
		/// Gets a list of contacts who were sent a campaign, with their activity.
		/// </summary>
		public ServiceResult<ApiCampaignContactSummaryList> GetCampaignActivities(int campaignId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactSummaryList>(request);
		}

		/// <summary>
		/// Gets a list of contacts who were sent a campaign, and retrieves only those contacts who showed activity (e.g. they clicked, opened) after a specified date.
		/// </summary>
		public ServiceResult<ApiCampaignContactSummaryList> GetCampaignActivitiesSinceDateByDate(int campaignId, DateTime date, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities/since-date/{date}?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactSummaryList>(request);
		}

		/// <summary>
		/// Gets activity for a given contact and campaign.
		/// </summary>
		public ServiceResult<ApiCampaignContactSummary> GetCampaignActivityByContactId(int campaignId, int contactId)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities/{contactId}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "contactId", contactId }
			});
			return Get<ApiCampaignContactSummary>(request);
		}

		/// <summary>
		/// Gets a list of campaign link clicks for a contact.
		/// </summary>
		public ServiceResult<ApiCampaignContactClickList> GetCampaignActivityClicks(int campaignId, int contactId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities/{contactId}/clicks?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "contactId", contactId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactClickList>(request);
		}

		/// <summary>
		/// Gets a list of campaign opens for a contact.
		/// </summary>
		public ServiceResult<ApiCampaignContactOpenList> GetCampaignActivityOpens(int campaignId, int contactId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities/{contactId}/opens?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "contactId", contactId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactOpenList>(request);
		}

		/// <summary>
		/// Gets a list of page views for a contact.
		/// </summary>
		public ServiceResult<ApiCampaignContactPageViewList> GetCampaignActivityPageViews(int campaignId, int contactId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities/{contactId}/page-views?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "contactId", contactId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactPageViewList>(request);
		}

		/// <summary>
		/// Gets a list of campaign replies for a contact. You may not request more than 5 records at a time using the "select" parameter.
		/// </summary>
		public ServiceResult<ApiCampaignContactReplyList> GetCampaignActivityReplies(int campaignId, int contactId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities/{contactId}/replies?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "contactId", contactId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactReplyList>(request);
		}

		/// <summary>
		/// Gets a list of ROI information for a contact.
		/// </summary>
		public ServiceResult<ApiCampaignContactRoiDetailList> GetCampaignActivityRoiDetails(int campaignId, int contactId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities/{contactId}/roi-details?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "contactId", contactId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactRoiDetailList>(request);
		}

		/// <summary>
		/// Gets campaign social bookmark views for a contact.
		/// </summary>
		public ServiceResult<ApiCampaignContactSocialBookmarkViewList> GetCampaignActivitySocialBookmarkViews(int campaignId, int contactId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/activities/{contactId}/social-bookmark-views?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "contactId", contactId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactSocialBookmarkViewList>(request);
		}

		/// <summary>
		/// Gets any address books that a campaign has ever been sent to.
		/// </summary>
		public ServiceResult<ApiAddressBookList> GetCampaignAddressBooks(int campaignId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/address-books?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiAddressBookList>(request);
		}

		/// <summary>
		/// Gets documents that are currently attached to a campaign.
		/// </summary>
		public ServiceResult<ApiDocumentList> GetCampaignAttachments(int campaignId)
		{
			var request = new Request("v2/campaigns/{campaignId}/attachments", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId }
			});
			return Get<ApiDocumentList>(request);
		}

		/// <summary>
		/// Gets a campaign by ID.
		/// </summary>
		public ServiceResult<ApiCampaign> GetCampaignById(int id)
		{
			var request = new Request("v2/campaigns/{id}", 
			new Dictionary<string, object>
			{
				{ "id", id }
			});
			return Get<ApiCampaign>(request);
		}

		/// <summary>
		/// Gets a list of campaign link clicks.
		/// </summary>
		public ServiceResult<ApiCampaignContactClickList> GetCampaignClicks(int campaignId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/clicks?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactClickList>(request);
		}

		/// <summary>
		/// Gets a list of contacts who hard bounced when sent a particular campaign.
		/// </summary>
		public ServiceResult<ApiContactList> GetCampaignHardBouncingContacts(int campaignId, bool? withFullData = null, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/hard-bouncing-contacts?withFullData={withFullData}&select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "withFullData", withFullData },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactList>(request);
		}

		/// <summary>
		/// Gets a list of campaign opens.
		/// </summary>
		public ServiceResult<ApiCampaignContactOpenList> GetCampaignOpens(int campaignId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/opens?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactOpenList>(request);
		}

		/// <summary>
		/// Gets a list of page views for a campaign after a specified date.
		/// </summary>
		public ServiceResult<ApiCampaignContactPageViewList> GetCampaignPageViewsSinceDateByDate(int campaignId, DateTime date, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/page-views/since-date/{date}?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactPageViewList>(request);
		}

		/// <summary>
		/// Retrieves a list of ROI information for a campaign after the specified date.
		/// </summary>
		public ServiceResult<ApiCampaignContactRoiDetailList> GetCampaignRoiDetailsSinceDateByDate(int campaignId, DateTime date, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/roi-details/since-date/{date}?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactRoiDetailList>(request);
		}

		/// <summary>
		/// Gets all campaigns
		/// </summary>
		public ServiceResult<ApiCampaignList> GetCampaigns(int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignList>(request);
		}

		/// <summary>
		/// Gets campaign social bookmark views for a campaign.
		/// </summary>
		public ServiceResult<ApiCampaignContactSocialBookmarkViewList> GetCampaignSocialBookmarkViews(int campaignId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/{campaignId}/social-bookmark-views?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignContactSocialBookmarkViewList>(request);
		}

		/// <summary>
		/// Gets the send status using send ID.
		/// </summary>
		public ServiceResult<ApiCampaignSend> GetCampaignsSendBySendId(Guid sendId)
		{
			var request = new Request("v2/campaigns/send/{sendId}", 
			new Dictionary<string, object>
			{
				{ "sendId", sendId }
			});
			return Get<ApiCampaignSend>(request);
		}

		/// <summary>
		/// Gets a summary of reporting information for a specified campaign.
		/// </summary>
		public ServiceResult<ApiCampaignSummary> GetCampaignSummary(int campaignId)
		{
			var request = new Request("v2/campaigns/{campaignId}/summary", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId }
			});
			return Get<ApiCampaignSummary>(request);
		}

		/// <summary>
		/// Gets all sent campaigns, which have had activity (e.g. clicks, opens) after a specified date.
		/// </summary>
		public ServiceResult<ApiCampaignList> GetCampaignsWithActivitySinceDate(DateTime date, int? select = null, int? skip = null)
		{
			var request = new Request("v2/campaigns/with-activity-since/{date}?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignList>(request);
		}

		/// <summary>
		/// Gets any address books that a contact is in.
		/// </summary>
		public ServiceResult<ApiAddressBookList> GetContactAddressBooks(int contactId, int? select = null, int? skip = null)
		{
			var request = new Request("v2/contacts/{contactId}/address-books?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "contactId", contactId },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiAddressBookList>(request);
		}

		/// <summary>
		/// Gets a contact by email address.
		/// </summary>
		public ServiceResult<ApiContact> GetContactByEmail(string email)
		{
			var request = new Request("v2/contacts/{email}", 
			new Dictionary<string, object>
			{
				{ "email", email }
			});
			return Get<ApiContact>(request);
		}

		/// <summary>
		/// Gets a contact by ID. Unsubscribed or suppressed contacts will not be retrieved.
		/// </summary>
		public ServiceResult<ApiContact> GetContactById(int id)
		{
			var request = new Request("v2/contacts/{id}", 
			new Dictionary<string, object>
			{
				{ "id", id }
			});
			return Get<ApiContact>(request);
		}

		/// <summary>
		/// Gets a list of all contacts in the account
		/// </summary>
		public ServiceResult<ApiContactList> GetContacts(bool? withFullData = null, int? select = null, int? skip = null)
		{
			var request = new Request("v2/contacts?withFullData={withFullData}&select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "withFullData", withFullData },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactList>(request);
		}

		/// <summary>
		/// Gets a list of created contacts after a specified date.
		/// </summary>
		public ServiceResult<ApiContactList> GetContactsCreatedSinceDate(DateTime date, bool? withFullData = null, int? select = null, int? skip = null)
		{
			var request = new Request("v2/contacts/created-since/{date}?withFullData={withFullData}&select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "withFullData", withFullData },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactList>(request);
		}

		/// <summary>
		/// Gets the import status of a previously started contact import.
		/// </summary>
		public ServiceResult<ApiContactImport> GetContactsImportByImportId(Guid importId)
		{
			var request = new Request("v2/contacts/import/{importId}", 
			new Dictionary<string, object>
			{
				{ "importId", importId }
			});
			return Get<ApiContactImport>(request);
		}

		/// <summary>
		/// Gets a report with statistics about what was successfully imported, and what was unable to be imported.
		/// </summary>
		public ServiceResult<ApiContactImportReport> GetContactsImportReport(Guid importId)
		{
			var request = new Request("v2/contacts/import/{importId}/report", 
			new Dictionary<string, object>
			{
				{ "importId", importId }
			});
			return Get<ApiContactImportReport>(request);
		}

		/// <summary>
		/// Gets all records that were not successfully imported. The data are returned in CSV file, which is UTF-8 encoded. This data will only be available for approximately one week after import.
		/// </summary>
		public ServiceResult GetContactsImportReportFaults(Guid importId)
		{
			var request = new Request("v2/contacts/import/{importId}/report-faults", 
			new Dictionary<string, object>
			{
				{ "importId", importId }
			});
			return Get(request);
		}

		/// <summary>
		/// Gets a list of modified contacts after a specified date.
		/// </summary>
		public ServiceResult<ApiContactList> GetContactsModifiedSinceDate(DateTime date, bool? withFullData = null, int? select = null, int? skip = null)
		{
			var request = new Request("v2/contacts/modified-since/{date}?withFullData={withFullData}&select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "withFullData", withFullData },
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactList>(request);
		}

		/// <summary>
		/// Gets a list of suppressed contacts after a given date along with the reason for suppression.
		/// </summary>
		public ServiceResult<ApiContactSuppressionList> GetContactsSuppressedSinceDate(DateTime date, int? select = null, int? skip = null)
		{
			var request = new Request("v2/contacts/suppressed-since/{date}?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactSuppressionList>(request);
		}

		/// <summary>
		/// Gets the import status of a previously started transactional import.
		/// </summary>
		public ServiceResult<ApiTransactionalDataImport> GetContactsTransactionalDataImportByImportId(Guid importId)
		{
			var request = new Request("v2/contacts/transactional-data/import/{importId}", 
			new Dictionary<string, object>
			{
				{ "importId", importId }
			});
			return Get<ApiTransactionalDataImport>(request);
		}

		/// <summary>
		/// Gets a report with statistics about what was successfully imported, and what was unable to be imported.
		/// </summary>
		public ServiceResult<ApiTransactionalDataImportReport> GetContactsTransactionalDataImportReport(Guid importId)
		{
			var request = new Request("v2/contacts/transactional-data/import/{importId}/report", 
			new Dictionary<string, object>
			{
				{ "importId", importId }
			});
			return Get<ApiTransactionalDataImportReport>(request);
		}

		/// <summary>
		/// Gets a list of unsubscribed contacts who unsubscribed after a given date.
		/// </summary>
		public ServiceResult<ApiContactSuppressionList> GetContactsUnsubscribedSinceDate(DateTime date, int? select = null, int? skip = null)
		{
			var request = new Request("v2/contacts/unsubscribed-since/{date}?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiContactSuppressionList>(request);
		}

		/// <summary>
		/// Gets all custom from addresses which can be used in a campaign.
		/// </summary>
		public ServiceResult<ApiCampaignFromAddressList> GetCustomFromAddresses(int? select = null, int? skip = null)
		{
			var request = new Request("v2/custom-from-addresses?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiCampaignFromAddressList>(request);
		}

		/// <summary>
		/// Gets all uploaded documents.
		/// </summary>
		public ServiceResult<ApiDocumentList> GetDocumentFolderDocuments(int folderId)
		{
			var request = new Request("v2/document-folders/{folderId}/documents", 
			new Dictionary<string, object>
			{
				{ "folderId", folderId }
			});
			return Get<ApiDocumentList>(request);
		}

		/// <summary>
		/// Fetches the document folder tree structure.
		/// </summary>
		public ServiceResult<ApiDocumentFolderList> GetDocumentFolders()
		{
			var request = new Request("v2/document-folders");
			return Get<ApiDocumentFolderList>(request);
		}

		/// <summary>
		/// Gets an image folder by id.
		/// </summary>
		public ServiceResult<ApiImageFolder> GetImageFolderById(int id)
		{
			var request = new Request("v2/image-folders/{id}", 
			new Dictionary<string, object>
			{
				{ "id", id }
			});
			return Get<ApiImageFolder>(request);
		}

		/// <summary>
		/// Fetches the campaign image folder tree structure.
		/// </summary>
		public ServiceResult<ApiImageFolderList> GetImageFolders()
		{
			var request = new Request("v2/image-folders");
			return Get<ApiImageFolderList>(request);
		}

		/// <summary>
		/// Gets all segments.
		/// </summary>
		public ServiceResult<ApiSegmentList> GetSegments(int? select = null, int? skip = null)
		{
			var request = new Request("v2/segments?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiSegmentList>(request);
		}

		/// <summary>
		/// Gets the UTC time as set on the server.
		/// </summary>
		public ServiceResult GetServerTime()
		{
			var request = new Request("v2/server-time");
			return Get(request);
		}

		/// <summary>
		/// Gets a template by ID.
		/// </summary>
		public ServiceResult<ApiTemplate> GetTemplateById(int id)
		{
			var request = new Request("v2/templates/{id}", 
			new Dictionary<string, object>
			{
				{ "id", id }
			});
			return Get<ApiTemplate>(request);
		}

		/// <summary>
		/// Gets list of all templates.
		/// </summary>
		public ServiceResult<ApiTemplateList> GetTemplates(int? select = null, int? skip = null)
		{
			var request = new Request("v2/templates?select={select}&skip={skip}", 
			new Dictionary<string, object>
			{
				{ "select", select },
				{ "skip", skip }
			});
			return Get<ApiTemplateList>(request);
		}
		/// <summary>
		/// Bulk creates, or bulk updates, contacts. Import format can either be CSV or Excel. Must include one column called "Email". Any other columns will attempt to map to your custom data fields. The ID of returned object can be used to query import progress.
		/// </summary>
		public ServiceResult<ApiContactImport> PostAddressBookContactsImport(int addressBookId)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts/import", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId }
			});
			return Post<ApiContactImport>(request);
		}

		/// <summary>
		/// Resubscribes a previously unsubscribed contact to a given address book.
		/// </summary>
		public ServiceResult<ApiResubscribeResult> PostAddressBookContactsResubscribe(int addressBookId, ApiContactResubscription apiContactResubscription)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts/resubscribe", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId },
			});
			return Post<ApiResubscribeResult, ApiContactResubscription>(request, apiContactResubscription);
		}

		/// <summary>
		/// Unsubscribes contact from a given address book.
		/// </summary>
		public ServiceResult<ApiContactSuppression> PostAddressBookContactsUnsubscribe(int addressBookId, ApiContact apiContact)
		{
			var request = new Request("v2/address-books/{addressBookId}/contacts/unsubscribe", 
			new Dictionary<string, object>
			{
				{ "addressBookId", addressBookId },
			});
			return Post<ApiContactSuppression, ApiContact>(request, apiContact);
		}

		/// <summary>
		/// Creates an address book.
		/// </summary>
		public ServiceResult<ApiAddressBook> PostAddressBooks(ApiAddressBook apiAddressBook)
		{
			var request = new Request("v2/address-books");
			return Post<ApiAddressBook>(request, apiAddressBook);
		}

		/// <summary>
		/// Copies a given campaign returning the new campaign.
		/// </summary>
		public ServiceResult<ApiCampaign> PostCampaignCopy(int campaignId)
		{
			var request = new Request("v2/campaigns/{campaignId}/copy", 
			new Dictionary<string, object>
			{
				{ "campaignId", campaignId }
			});
			return Post<ApiCampaign>(request);
		}

		/// <summary>
		/// Creates a campaign.
		/// </summary>
		public ServiceResult<ApiCampaign> PostCampaigns(ApiCampaign apiCampaign)
		{
			var request = new Request("v2/campaigns");
			return Post<ApiCampaign>(request, apiCampaign);
		}

		/// <summary>
		/// Sends a specified campaign to one or more address books, segments or contacts at a specified time. Leave the address book array empty to send to All Contacts.
		/// </summary>
		public ServiceResult<ApiCampaignSend> PostCampaignsSend(ApiCampaignSend apiCampaignSend)
		{
			var request = new Request("v2/campaigns/send");
			return Post<ApiCampaignSend>(request, apiCampaignSend);
		}

		/// <summary>
		/// Creates a contact.
		/// </summary>
		public ServiceResult<ApiContact> PostContacts(ApiContact apiContact)
		{
			var request = new Request("v2/contacts");
			return Post<ApiContact>(request, apiContact);
		}

		/// <summary>
		/// Bulk creates, or bulk updates, contacts. Import format can either be CSV or Excel. Must include one column called "Email". Any other columns will attempt to map to your custom data fields. The ID of returned object can be used to query import progress.
		/// </summary>
		public ServiceResult<ApiContactImport> PostContactsImport()
		{
			var request = new Request("v2/contacts/import");
			return Post<ApiContactImport>(request);
		}

		/// <summary>
		/// Resubscribes a previously unsubscribed contact.
		/// </summary>
		public ServiceResult<ApiResubscribeResult> PostContactsResubscribe(ApiContactResubscription apiContactResubscription)
		{
			var request = new Request("v2/contacts/resubscribe");
			return Post<ApiResubscribeResult, ApiContactResubscription>(request, apiContactResubscription);
		}

		/// <summary>
		/// Adds a single piece of transactional data to a contact.
		/// </summary>
		public ServiceResult<ApiTransactionalData> PostContactsTransactionalData(string collectionName, ApiTransactionalData apiTransactionalData)
		{
			var request = new Request("v2/contacts/transactional-data/{collectionName}", 
			new Dictionary<string, object>
			{
				{ "collectionName", collectionName },
			});
			return Post<ApiTransactionalData>(request, apiTransactionalData);
		}

		/// <summary>
		/// Replaces a piece of transactional data by key (logicall equivalent to a delete and an insert).
		/// </summary>
		public ServiceResult<ApiTransactionalData> PostContactsTransactionalData(string collectionName, string key, ApiJsonData apiJsonData)
		{
			var request = new Request("v2/contacts/transactional-data/{collectionName}/{key}", 
			new Dictionary<string, object>
			{
				{ "collectionName", collectionName },
				{ "key", key },
			});
			return Post<ApiTransactionalData, ApiJsonData>(request, apiJsonData);
		}

		/// <summary>
		/// Adds multiple pieces of transactional data to contacts asynchronously, returning an identifier that can be used to check for import progress.
		/// </summary>
		public ServiceResult<ApiTransactionalDataImport> PostContactsTransactionalDataImport(string collectionName, ApiTransactionalDataList apiTransactionalData)
		{
			var request = new Request("v2/contacts/transactional-data/import/{collectionName}", 
			new Dictionary<string, object>
			{
				{ "collectionName", collectionName },
			});
			return Post<ApiTransactionalDataImport, ApiTransactionalDataList>(request, apiTransactionalData);
		}

		/// <summary>
		/// Unsubscribes contact from account.
		/// </summary>
		public ServiceResult<ApiContactSuppression> PostContactsUnsubscribe(ApiContact apiContact)
		{
			var request = new Request("v2/contacts/unsubscribe");
			return Post<ApiContactSuppression, ApiContact>(request, apiContact);
		}

		/// <summary>
		/// Creates a data field within the account.
		/// </summary>
		public ServiceResult PostDataFields(ApiDataField dataField)
		{
			var request = new Request("v2/data-fields");
			return Post(request, dataField);
		}

		/// <summary>
		/// Creates a new document folder.
		/// </summary>
		public ServiceResult<ApiDocumentFolder> PostDocumentFolder(int folderId, ApiDocumentFolder folder)
		{
			var request = new Request("v2/document-folders/{folderId}", 
			new Dictionary<string, object>
			{
				{ "folderId", folderId },
			});
			return Post<ApiDocumentFolder>(request, folder);
		}

		/// <summary>
		/// Uploads a new campaign image to the specified folder.
		/// </summary>
		public ServiceResult<ApiImage> PostImageFolderImages(int folderId)
		{
			var request = new Request("v2/image-folders/{folderId}/images", 
			new Dictionary<string, object>
			{
				{ "folderId", folderId }
			});
			return Post<ApiImage>(request);
		}

		/// <summary>
		/// Refreshes a segment by ID.
		/// </summary>
		public ServiceResult<ApiSegmentRefresh> PostSegmentsRefreh(int id)
		{
			var request = new Request("v2/segments/refresh/{id}", 
			new Dictionary<string, object>
			{
				{ "id", id }
			});
			return Post<ApiSegmentRefresh>(request);
		}

		/// <summary>
		/// Send a single SMS message.
		/// </summary>
		public ServiceResult PostSmsMessagesSendTo(string telephoneNumber, ApiSms sms)
		{
			var request = new Request("v2/sms-messages/send-to/{telephoneNumber}", 
			new Dictionary<string, object>
			{
				{ "telephoneNumber", telephoneNumber },
			});
			return Post(request, sms);
		}

		/// <summary>
		/// Creates a template.
		/// </summary>
		public ServiceResult<ApiTemplate> PostTemplates(ApiTemplate template)
		{
			var request = new Request("v2/templates");
			return Post<ApiTemplate>(request, template);
		}


    }
}
