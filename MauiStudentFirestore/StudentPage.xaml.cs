using MauiStudentFirestore.Services;
using MauiStudentFirestore.ViewModels;

namespace MauiStudentFirestore;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}