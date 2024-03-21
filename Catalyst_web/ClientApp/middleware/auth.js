//middleware/auth.js

export default function ({ $auth, redirect, route }) {
  // Check if the user is accessing a page that requires authentication
  if (!$auth.loggedIn) {
    // Redirect to the login page if the user is not authenticated
    return redirect('/');
  }
}
