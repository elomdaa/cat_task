#include <iostream>
#include<vector>

using namespace std;

int calc_function(vector<string> arr) {
    int ans = 0;
    for (auto it : arr) {
        if (it == "++") {
            ans++;
        } else if (it == "--") {
            ans--;
        }
    }
    return ans;
}

int main()
{
    int n; cin>>n;
    vector<string> arr(n);
    for(int i =0 ;i<n ;i++)
    {
        cin>>arr[i];
    }
    int ans =calc_function(arr);
    cout<<ans<<'\n';
    return 0;
}
