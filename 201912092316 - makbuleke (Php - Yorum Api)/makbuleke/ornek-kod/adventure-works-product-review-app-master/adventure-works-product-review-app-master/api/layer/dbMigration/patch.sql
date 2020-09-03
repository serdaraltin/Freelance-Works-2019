ALTER TABLE adventureworks.productreview
  CHANGE ReviewDate ReviewDate TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP;
ALTER TABLE productreview ADD Status varchar(50);
ALTER TABLE productreview ADD CONSTRAINT productreview_product_ProductID_fk
FOREIGN KEY (ProductID) REFERENCES product (ProductID);
ALTER TABLE productreview ALTER COLUMN Rating SET DEFAULT -1;