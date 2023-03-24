CREATE TABLE [ms_storage_location] (
  [location_id] varchar(10) PRIMARY KEY,
  [location_name] varchar(100)
)
GO

CREATE TABLE [tr_bpkb] (
  [agreement_number] varchar(100) PRIMARY KEY,
  [bpkb_no] varchar(100),
  [branch_id] varchar(10),
  [bpkb_date] datetime,
  [faktur_no] varchar(100),
  [faktur_date] datetime,
  [location_id] varchar(10),
  [police_no] varchar(20),
  [bpkb_date_in] datetime
)
GO

ALTER TABLE [tr_bpkb] ADD FOREIGN KEY ([location_id]) REFERENCES [ms_storage_location] ([location_id])
GO
