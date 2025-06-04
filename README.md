
# 📖 HƯỚNG DẪN SỬ DỤNG HỆ THỐNG QUẢN LÝ DỊCH VỤ CHO THUÊ XE

## ⚙️ Cài đặt cơ sở dữ liệu

1. **Restore** file `QuanLyThueXe.bak` vào **SQL Server Management Studio 20**.
2. Mở **SQL Server Management Studio 20**, copy tên **Server** và dán vào file `DBConnect.cs` tại dòng 19:
   ```csharp
   DataSource = "Server Name";
   ```

---

## 🔐 Tài khoản đăng nhập hệ thống

| Tài khoản  | Mật khẩu  | Quyền truy cập                               |
|:-----------|:----------|:---------------------------------------------|
| `admin`    | `1111`    | Toàn quyền hệ thống                          |
| `nv001`    | `1111`    | Giới hạn quyền thống kê và quản lý nhân viên |
| `nv002`    | `1111`    | Giới hạn quyền thống kê và quản lý nhân viên |
| `nv003`    | `1111`    | Giới hạn quyền thống kê và quản lý nhân viên |
| `nv004`    | `1111`    | Giới hạn quyền thống kê và quản lý nhân viên |
| `nv005`    | `1111`    | Giới hạn quyền thống kê và quản lý nhân viên |

---
