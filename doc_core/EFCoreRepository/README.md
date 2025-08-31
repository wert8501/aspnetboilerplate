# EF Core Repository 權威指南

## 關於本指南

歡迎來到 **EF Core Repository 權威指南**！本指南是一份針對 ASP.NET Boilerplate 框架中 Entity Framework Core Repository 的深度技術文件，專為想要深入了解和掌握 Repository Pattern 實作的資深工程師而撰寫。

## 指南特色

- 📚 **深度解析**：從理論基礎到實作細節，全面剖析 EF Core Repository
- 🔍 **程式碼探索**：深入分析 ABP 框架原始碼，揭示設計理念與實作邏輯
- 🎯 **實戰導向**：結合實際專案需求，提供最佳實踐指導
- 📊 **視覺化呈現**：豐富的 Mermaid 圖表，讓複雜概念一目了然
- 🧪 **測試驅動**：完整的測試策略，確保程式碼品質

## 目標讀者

- 資深軟體工程師
- 系統架構師
- .NET 技術專家
- 對 Repository Pattern 有深度學習需求的開發者

## 技術前提

- 熟悉 C# 和 .NET Core/.NET 5+
- 具備 Entity Framework Core 使用經驗
- 了解基本的設計模式概念
- 有 ASP.NET Core 開發經驗

## 章節導覽

### 📖 第一章：[Repository Pattern 理論基礎](./01-Repository%20Pattern%20理論基礎.md)
**重點內容**：Repository Pattern 的定義、核心概念與設計理念
- Repository Pattern 與 DDD 的關係
- Generic Repository vs Specific Repository
- ABP 框架中的 Repository 設計哲學

### 🏗️ 第二章：[ABP 框架中的 Repository 架構](./02-ABP%20框架中的%20Repository%20架構.md)
**重點內容**：深入了解 ABP Repository 的架構設計
- Repository 介面族譜分析
- 泛型 Repository 自動註冊機制
- 依賴注入與生命週期管理

### 🔗 第三章：[DbContext 與 Repository 的協作機制](./03-DbContext%20與%20Repository%20的協作機制.md)
**重點內容**：探討 DbContext 與 Repository 的深度整合
- `IDbContextProvider` 工廠模式實作
- 多 DbContext 環境管理
- Connection String 解析與多租戶支援

### 🔄 第四章：[Unit of Work 與交易管理](./04-Unit%20of%20Work%20與交易管理.md)
**重點內容**：Unit of Work 模式的深度應用
- `EfCoreUnitOfWork` 核心實作
- 嵌套 Unit of Work 處理策略
- 交易管理與回滾機制

### 💾 第五章：[Repository CRUD 操作深度解析](./05-Repository%20CRUD%20操作深度解析.md)
**重點內容**：全面解析 Repository 的 CRUD 操作
- Query 操作最佳化策略
- Insert/Update 變更追蹤原理
- 軟刪除與硬刪除實作
- Batch 操作效能最佳化

### 🛠️ 第六章：[自訂 Repository 設計與實作](./06-自訂%20Repository%20設計與實作.md)
**重點內容**：指導自訂 Repository 的設計與實作
- Application-Specific Repository 建立
- Domain-Specific Repository 策略
- 複雜查詢封裝技巧

### ⚡ 第七章：[效能最佳化與進階特性](./07-效能最佳化與進階特性.md)
**重點內容**：Repository 效能最佳化與進階功能
- Query Compilation 與快取
- Global Filters 配置
- Connection Pooling 資源管理

### 🧪 第八章：[測試策略與最佳實踐](./08-測試策略與最佳實踐.md)
**重點內容**：建立完整的 Repository 測試體系
- 單元測試與整合測試策略
- In-Memory Database 應用
- Test Data Builder Pattern 實作

## 學習路徑建議

### 🚀 快速入門路徑（適合有經驗的開發者）
1. 第二章 → 第三章 → 第五章 → 第六章

### 📚 完整學習路徑（建議的學習順序）
1. 第一章：建立理論基礎
2. 第二章：了解架構設計
3. 第三章：掌握協作機制
4. 第四章：理解交易管理
5. 第五章：精通 CRUD 操作
6. 第六章：實作自訂 Repository
7. 第七章：效能最佳化
8. 第八章：測試策略

### 🎯 專題學習路徑
- **效能專精**：第五章 → 第七章
- **測試專精**：第八章 → 相關章節實踐
- **架構設計**：第一章 → 第二章 → 第六章

## 實踐專案

本指南以 ASP.NET Boilerplate 的 Demo 專案為實際範例，所有程式碼分析都基於真實的專案結構：

```
demo/
├── src/
│   ├── Demo.Application/
│   ├── Demo.Core/
│   ├── Demo.EntityFrameworkCore/
│   └── Demo.Web.*/
└── test/
    ├── Demo.Tests/
    └── Demo.Web.Tests/
```

## 輔助資源

- **原始碼分析**：深入 ABP 框架 `src/` 目錄的原始碼
- **測試案例**：參考 `test/` 目錄中的測試實作
- **圖表說明**：Mermaid 圖表輔助理解複雜概念
- **最佳實踐**：每章節都包含實用的最佳實踐建議

## 輔助資源

- **[📋 快速參考指南](./快速參考指南.md)** - 常用操作、介面速查、最佳實踐檢查清單
- **[📂 專案結構與程式碼導覽](./專案結構與程式碼導覽.md)** - 框架程式碼位置、學習路徑指引

## 如何使用本指南

1. **循序漸進**：建議按照章節順序閱讀，每個章節都基於前面的知識
2. **實作驗證**：每讀完一個章節，建議在實際專案中嘗試相關技術
3. **深度理解**：不要急於求成，確保理解每個概念後再繼續
4. **交叉參考**：善用章節間的交叉參考，建立完整的知識體系

## 意見回饋

如果您在學習過程中有任何問題或建議，歡迎提出意見。本指南持續更新，旨在為 .NET 社群提供最高品質的技術文件。

---

**開始您的 EF Core Repository 深度學習之旅！** 🚀

選擇您感興趣的章節開始閱讀，或從[第一章：Repository Pattern 理論基礎](./01-Repository%20Pattern%20理論基礎.md)開始建立堅實的理論基礎。
