USE [QUANLYTRUONGHOC]
GO
/****** Object:  StoredProcedure [dbo].[insertLopHoc]    Script Date: 11/15/2022 1:08:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[insertLopHoc]
   	@ma_ky_hoc tinyint,
   	@ma_mon_hoc int,
   	@ma_giang_vien int,
   	@da_xoa bit
as
begin
   	insert into LOPHOC(ma_ky_hoc, ma_mon_hoc,ma_giang_vien)
   	values(@ma_ky_hoc,@ma_mon_hoc,@ma_giang_vien);
end
