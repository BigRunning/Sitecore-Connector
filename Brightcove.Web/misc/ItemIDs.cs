﻿namespace Sitecore.MediaFramework
{
  using Sitecore.Data;                   
                              
  public static class ItemIDs  
  {
    public static readonly ID MediaFrameworkRoot = new ID("{1ADBC873-DFBF-4C09-853E-AC71E6D59739}");

    public static readonly ID AccountsRoot = new ID("{E7291614-A88D-4512-92B7-1DAE99309D26}");

    public static readonly ID EmbedMediaDialog = new ID("{D74E5D33-429A-4391-BFF5-E5B6064DE10A}");

    public static readonly ID EmbedMediaApplication = new ID("{92272FE4-FC90-498B-86B4-FE92B98E2038}");

    public static readonly ID UploadApplication = new ID("{E7C6251E-C323-4562-94CB-85FCF2BCB933}");

    public static readonly ID EmbedMediaSublayout = new ID("{E393D906-954F-4442-A302-8029ED7A8EB0}");

    public static readonly ID ClientId = new ID("{E7FCF624-4A36-4BE8-B2F5-D5C30BE677C4}");

    public static readonly ID ClientSecret = new ID("{F537C3A0-152C-4AE1-A21B-EBF69B8EE51B}");

    public static readonly ID PublisherId = new ID("{3B2A0B52-EEB1-42A9-989D-DD0F57986E67}");

    public static class PageEvents
    {
      public static readonly ID PlaybackStarted = new ID("{76B6B0EA-F4BC-41AC-8BBA-CD4BBBF8E438}");

      public static readonly ID PlaybackCompleted = new ID("{035B4467-A848-4D57-A465-401B035FDE98}");

      public static readonly ID PlaybackChanged = new ID("{634C87A9-4E01-4C69-9522-215865012DC5}");

      public static readonly ID PlaybackError = new ID("{5F51C65D-796C-43BE-B9C4-5855159AF18B}");
    }
  }
}