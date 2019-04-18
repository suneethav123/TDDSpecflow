﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OneAtmosphere.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Salesforce", SourceFile="Features\\Salesforce.feature", SourceLine=0)]
    public partial class SalesforceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Salesforce.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Salesforce", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify that assigning \'My Account\' permission to a demo user is accessible", new string[] {
                "mytagP1"}, SourceLine=4)]
        public virtual void VerifyThatAssigningMyAccountPermissionToADemoUserIsAccessible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that assigning \'My Account\' permission to a demo user is accessible", null, new string[] {
                        "mytagP1"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
    testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.Then("Click on User Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.Then("Landed on User Administration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify that assigning \'Treasury Access\' permission to a demo user is accessible", new string[] {
                "mytagP1"}, SourceLine=29)]
        public virtual void VerifyThatAssigningTreasuryAccessPermissionToADemoUserIsAccessible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that assigning \'Treasury Access\' permission to a demo user is accessible", null, new string[] {
                        "mytagP1"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 31
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.Then("Remove \'Treasury\' permission from Demo user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.Given("Verify Treasury in OneAtmos after removing permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.Then("Assign \'Treasury\' permission to Demo User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.Given("Verify Treasury in OneAtmos after assigning permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify that assigning \'Tax Access\' permission to a demo user is accessible", new string[] {
                "mytagP1"}, SourceLine=46)]
        public virtual void VerifyThatAssigningTaxAccessPermissionToADemoUserIsAccessible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that assigning \'Tax Access\' permission to a demo user is accessible", null, new string[] {
                        "mytagP1"});
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 48
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.Then("Remove \'Tax\' permission from Demo user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.Given("Verify Tax in OneAtmos after removing permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
 testRunner.Then("Assign \'Tax\' permission to Demo User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.Given("Verify Tax in OneAtmos after assigning permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify that assigning \'My account\' and \'Treasury Access\' permissions to a demo us" +
            "er is accessible", new string[] {
                "mytagP1"}, SourceLine=63)]
        public virtual void VerifyThatAssigningMyAccountAndTreasuryAccessPermissionsToADemoUserIsAccessible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that assigning \'My account\' and \'Treasury Access\' permissions to a demo us" +
                    "er is accessible", null, new string[] {
                        "mytagP1"});
#line 64
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 65
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 66
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.Then("Remove \'MyAccount\' permission from Demo user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.Then("Remove \'Treasury\' permission from Demo user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.Given("Verify MyAccount in OneAtmos after removing permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
 testRunner.Given("Verify Treasury in OneAtmos after removing permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
 testRunner.Then("Assign \'MyAccount\' permission to Demo User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.Then("Assign \'Treasury\' permission to Demo User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.Given("Verify MyAccount in OneAtmos after assigning permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 79
 testRunner.Given("Verify Treasury in OneAtmos after assigning permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify that assigning \'My account\' and \'Tax Access\' premissions to a demo user is" +
            " accessible", new string[] {
                "mytagP1"}, SourceLine=84)]
        public virtual void VerifyThatAssigningMyAccountAndTaxAccessPremissionsToADemoUserIsAccessible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that assigning \'My account\' and \'Tax Access\' premissions to a demo user is" +
                    " accessible", null, new string[] {
                        "mytagP1"});
#line 85
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 86
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 87
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.Then("Remove \'MyAccount\' permission from Demo user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.Then("Remove \'Tax\' permission from Demo user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.Given("Verify MyAccount in OneAtmos after removing permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
 testRunner.Given("Verify Tax in OneAtmos after removing permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 96
 testRunner.Then("Assign \'MyAccount\' permission to Demo User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.Then("Assign \'Tax\' permission to Demo User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.Given("Verify MyAccount in OneAtmos after assigning permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 100
 testRunner.Given("Verify Tax in OneAtmos after assigning permission", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 101
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Tax Collection >> ACH Money Movement Type - Create Money transaction record in sa" +
            "lesforce and validate in the OSVAtmosphere", new string[] {
                "mytagP1"}, SourceLine=106)]
        public virtual void TaxCollectionACHMoneyMovementType_CreateMoneyTransactionRecordInSalesforceAndValidateInTheOSVAtmosphere()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tax Collection >> ACH Money Movement Type - Create Money transaction record in sa" +
                    "lesforce and validate in the OSVAtmosphere", null, new string[] {
                        "mytagP1"});
#line 107
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 108
    testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 109
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.Then("Now click on Money Transcation Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.Then("Click on New button present in the Home page of Money Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.Then("Enter Account details and Tenant Details in Money Transaction page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.Then("Select \'Approved\' status for the New Money Transation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
 testRunner.Then("Select \'Tax Collection\' Transaction Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 116
 testRunner.Then("Select \'ACH\' Money Movement type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.Then("Enter Adjusted Total Dollar Ammount as \'5000\' and Total Dollar Amount as \'5000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.Then("Enter \'09/10/2018\' as Settlement date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.Then("Enter Bank details Bank name as \'Bank of America\', Bank ABN Num as \'100235678\', B" +
                    "ank Acc Num as \'1111111111\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
    testRunner.Then("Select \'Wells Fargo\' VRP Processing Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.Then("Click on save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 123
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.Then("Click on Ellipses icon under Treasury section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 126
 testRunner.And("Verify \'Tax Collection\' record in Treasury section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.Then("Delete created transaction in Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("DDP Collection >> ACH Money Movement Type - Create a new \'Money transaction\' with" +
            " \'Approved\' Status for Future settlement date", new string[] {
                "mytagP1"}, SourceLine=133)]
        public virtual void DDPCollectionACHMoneyMovementType_CreateANewMoneyTransactionWithApprovedStatusForFutureSettlementDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DDP Collection >> ACH Money Movement Type - Create a new \'Money transaction\' with" +
                    " \'Approved\' Status for Future settlement date", null, new string[] {
                        "mytagP1"});
#line 134
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 135
    testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 136
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 138
 testRunner.Then("Now click on Money Transcation Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
 testRunner.Then("Click on New button present in the Home page of Money Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.Then("Enter Account details and Tenant Details in Money Transaction page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
 testRunner.Then("Select \'Approved\' status for the New Money Transation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.Then("Select \'DPP Collection\' Transaction Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
 testRunner.Then("Select \'ACH\' Money Movement type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.Then("Enter Adjusted Total Dollar Ammount as \'7000\' and Total Dollar Amount as \'7000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 145
 testRunner.Then("Enter \'09/10/2018\' as Settlement date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.Then("Enter Bank details Bank name as \'Bank of America\', Bank ABN Num as \'100235678\', B" +
                    "ank Acc Num as \'2222222222\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
    testRunner.Then("Select \'Wells Fargo\' VRP Processing Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
 testRunner.Then("Click on save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 149
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 150
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 152
 testRunner.Then("Click on Ellipses icon under Treasury section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
 testRunner.And("Verify \'DPP Collection\' record in Treasury section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 157
 testRunner.Then("Delete created transaction in Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Garnishment Collection >> ACH Money Movement Type - Create a new \'Money Transacti" +
            "on\' with \'Approved\' Status for Future Settlement date", new string[] {
                "mytagP1"}, SourceLine=160)]
        public virtual void GarnishmentCollectionACHMoneyMovementType_CreateANewMoneyTransactionWithApprovedStatusForFutureSettlementDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Garnishment Collection >> ACH Money Movement Type - Create a new \'Money Transacti" +
                    "on\' with \'Approved\' Status for Future Settlement date", null, new string[] {
                        "mytagP1"});
#line 161
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 162
    testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 163
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 164
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 165
 testRunner.Then("Now click on Money Transcation Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 166
 testRunner.Then("Click on New button present in the Home page of Money Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 167
 testRunner.Then("Enter Account details and Tenant Details in Money Transaction page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 168
 testRunner.Then("Select \'Approved\' status for the New Money Transation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 169
 testRunner.Then("Select \'Garnishment Collection\' Transaction Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 170
 testRunner.Then("Select \'ACH\' Money Movement type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 171
 testRunner.Then("Enter Adjusted Total Dollar Ammount as \'7000\' and Total Dollar Amount as \'7000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 172
 testRunner.Then("Enter \'09/10/2018\' as Settlement date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 173
 testRunner.Then("Enter Bank details Bank name as \'Bank of America\', Bank ABN Num as \'100235678\', B" +
                    "ank Acc Num as \'3333333333\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
    testRunner.Then("Select \'Wells Fargo\' VRP Processing Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.Then("Click on save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 177
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 178
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 179
 testRunner.Then("Click on Ellipses icon under Treasury section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
 testRunner.And("Verify \'Garnishment Collection\' record in Treasury section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 182
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 183
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 184
 testRunner.Then("Delete created transaction in Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 185
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("DPP Refund >> ACH Money Movement Type - Create a new \'Money Transaction\' with \'Ap" +
            "proved\' Status for current date", new string[] {
                "mytagP1"}, SourceLine=187)]
        public virtual void DPPRefundACHMoneyMovementType_CreateANewMoneyTransactionWithApprovedStatusForCurrentDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DPP Refund >> ACH Money Movement Type - Create a new \'Money Transaction\' with \'Ap" +
                    "proved\' Status for current date", null, new string[] {
                        "mytagP1"});
#line 188
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 189
    testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 190
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 191
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 192
 testRunner.Then("Now click on Money Transcation Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 193
 testRunner.Then("Click on New button present in the Home page of Money Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 194
 testRunner.Then("Enter Account details and Tenant Details in Money Transaction page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 195
 testRunner.Then("Select \'Approved\' status for the New Money Transation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
 testRunner.Then("Select \'DDP Refund\' Transaction Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 197
 testRunner.Then("Select \'ACH\' Money Movement type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 198
 testRunner.Then("Enter Adjusted Total Dollar Ammount as \'7000\' and Total Dollar Amount as \'7000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
 testRunner.Then("Click on Today date link for settlement date.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 200
 testRunner.Then("Enter Bank details Bank name as \'Bank of America\', Bank ABN Num as \'100235678\', B" +
                    "ank Acc Num as \'4444444444\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 201
    testRunner.Then("Select \'Wells Fargo\' VRP Processing Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 202
 testRunner.Then("Click on save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 203
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 204
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 205
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 206
 testRunner.Then("Navigates to Todays Transaction tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 207
 testRunner.And("Verify \'DDP Refund\' record in Treasury section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 208
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 209
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 210
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 211
 testRunner.Then("Delete created transaction in Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 212
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Tax Refund >> ACH Money Movement Type - Create a new \'Money Transaction\' with \'Ap" +
            "proved\' Status for current date", new string[] {
                "mytagP1"}, SourceLine=214)]
        public virtual void TaxRefundACHMoneyMovementType_CreateANewMoneyTransactionWithApprovedStatusForCurrentDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tax Refund >> ACH Money Movement Type - Create a new \'Money Transaction\' with \'Ap" +
                    "proved\' Status for current date", null, new string[] {
                        "mytagP1"});
#line 215
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 216
    testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 217
 testRunner.Then("Navigate To SalesForce Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 218
 testRunner.Then("Login into Salesforce with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 219
 testRunner.Then("Now click on Money Transcation Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 220
 testRunner.Then("Click on New button present in the Home page of Money Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 221
 testRunner.Then("Enter Account details and Tenant Details in Money Transaction page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 222
 testRunner.Then("Select \'Approved\' status for the New Money Transation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 223
 testRunner.Then("Select \'Tax Refund\' Transaction Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 224
 testRunner.Then("Select \'ACH\' Money Movement type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 225
 testRunner.Then("Enter Adjusted Total Dollar Ammount as \'7000\' and Total Dollar Amount as \'7000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 226
 testRunner.Then("Click on Today date link for settlement date.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 227
 testRunner.Then("Enter Bank details Bank name as \'Bank of America\', Bank ABN Num as \'100235678\', B" +
                    "ank Acc Num as \'5555555555\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 228
    testRunner.Then("Select \'Wells Fargo\' VRP Processing Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 229
 testRunner.Then("Click on save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 230
 testRunner.Given("Open browser \'chrome\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 231
 testRunner.Then("Navigate to url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 232
 testRunner.Then("Enter username and password and login into OSVAtmos site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 233
 testRunner.Then("Navigates to Todays Transaction tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 234
 testRunner.And("Verify \'Tax Refund\' record in Treasury section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 235
 testRunner.Then("Logout from application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 236
 testRunner.Then("Verify the logout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 237
 testRunner.Then("Quit browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 238
 testRunner.Then("Delete created transaction in Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 239
 testRunner.Then("Logout from Salesforce", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion

